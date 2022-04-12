using System.Collections.Generic;
using UnityEngine;
public class view : MonoBehaviour
{
    [SerializeField]private float distance;
    [SerializeField] private LayerMask collider;
    private ChangeView roof;
    [SerializeField]private ChangeView[] roofs;
    
    
    private void Start()
    {
        roofs = new ChangeView[4];
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
                roofs[i] = hits[i].transform.gameObject.GetComponent<ChangeView>();
                roofs[i].HideRoof();
            }

        
       
        if(hits.Length == 0)
        {
            for (int i = 0; i < roofs.Length; i++)
                if(roofs[i]!= null)
                    roofs[i].ViewRoof();
        }
           
            


        
        



        
           
            
        // tema de rendimientno hacer getcomponet en update 
        //tema  de cambio de color "corrutinas "
    }
}
