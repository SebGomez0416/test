using UnityEngine;

public class test : MonoBehaviour
{
    private CharacterController cc;
    private Vector3 movement;
    [SerializeField] private float speed;
    [SerializeField]private float distance;
    [SerializeField] private LayerMask collider;
    
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Debug.DrawRay(transform.position,Vector3.down * distance, Color.red);
        
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position,Vector3.down,out hit,distance,collider))
        {
           transform.up = hit.normal;
        }
        
        movement.x =  Input.GetAxisRaw("Horizontal")* speed*Time.deltaTime;
        movement.z =  Input.GetAxisRaw("Vertical")* speed*Time.deltaTime;

        cc.Move(movement);
   }




}
