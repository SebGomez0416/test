using System;
using UnityEngine;
public class view : MonoBehaviour
{
    [SerializeField]private float distance;
    [SerializeField] private LayerMask collider;
    private ChangeView roof;
    [SerializeField]private ChangeView[] roofs;
    
    private void Start()
    {
        roofs = new ChangeView[3];
    }

    private void Update()
    {
        Debug.DrawRay(transform.position,transform.up* distance, Color.red);
        
        //hard
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position,Vector3.up,out hit,distance,collider))
        { 
            // easy
           // hit.transform.gameObject.SetActive(false);
           
           roof= hit.transform.gameObject.GetComponent<ChangeView>();
           roof.HideRoof();
        }
        
        else
        {
           if (roof == null) return;
           roof.ViewRoof();
        }*/
        
        //Nightmare  // 
        
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, Vector3.up, distance, collider);

        for (int i = 0; i < hits.Length; i++)
        {
            roofs[i]= hits[i].transform.gameObject.GetComponent<ChangeView>();
            roofs[i].HideRoof();
        }



        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].transform.gameObject.CompareTag("roof") )
                roofs[i].ViewRoof();

        }
           
            
        // tema de rendimientno hacer getcomponet en update 
        //tema  de cambio de color "corrutinas "
    }
}
