using System;
using System.Collections;
using UnityEngine;
 
public class ChangeView : MonoBehaviour
{
    private Material _material;
    [SerializeField] private float lerpTime;
    [SerializeField] private float time;
    private bool change;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    public void HideRoof()
    {
        //medium
        //_material.color = Color.clear;
       
       //hard
       if (change) return;
       StartCoroutine("FadeOut");
    }
    public void ViewRoof()
    {
        // medium
        // _material.color = Color.blue;
        
        //hard
        if (!change) return;
        StartCoroutine("FadeIn");

    }

    IEnumerator FadeIn()
    {
        change = false; 
        lerpTime += 0.1f;
        _material.color = Color.Lerp(Color.clear,Color.blue,lerpTime);
        yield return new WaitForSeconds(time);
        if (lerpTime <= 1)
            StartCoroutine("FadeIn");
        else lerpTime = 0;
    }
    
    IEnumerator FadeOut()
    {   
        change = true;
        lerpTime += 0.1f;
        _material.color = Color.Lerp(Color.blue,Color.clear,lerpTime);
        yield return new WaitForSeconds(time);
        if(lerpTime<=1)
            StartCoroutine("FadeOut");
        else lerpTime = 0;
    }
    
    
}
