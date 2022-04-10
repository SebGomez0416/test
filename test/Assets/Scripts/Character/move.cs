using UnityEngine;

public class move : MonoBehaviour
{
    private CharacterController cc;
    private Vector3 movement;
    [SerializeField] private float speed;
    
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal")* speed;
        movement.z = Input.GetAxisRaw("Vertical")* speed;
        
        cc.SimpleMove(movement);
    }
}
