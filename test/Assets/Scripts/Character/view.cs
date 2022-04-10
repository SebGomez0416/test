using UnityEngine;
public class view : MonoBehaviour
{
    [SerializeField]private float distance;
    [SerializeField] private LayerMask collider;
    private void Update()
    {
        Debug.DrawRay(transform.position,transform.up* distance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(transform.position,Vector3.up,out hit,distance,collider))
        {
            hit.collider.gameObject.SetActive(false);
        }
    }
}
