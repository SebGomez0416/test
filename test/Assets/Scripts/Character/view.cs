using UnityEngine;
public class view : MonoBehaviour
{
    [SerializeField]private float distance;
    [SerializeField] private LayerMask collider;
    private ChangeView roof;
    private void Update()
    {
        Debug.DrawRay(transform.position,transform.up* distance, Color.red);

        RaycastHit hit;
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
        }
    }
}
