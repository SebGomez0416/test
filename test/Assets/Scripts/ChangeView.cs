using UnityEngine;
 
public class ChangeView : MonoBehaviour
{
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    public void HideRoof()
    {
        _material.color = Color.clear;
    }
    public void ViewRoof()
    {
        _material.color = Color.blue;
    }
}
