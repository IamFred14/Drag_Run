using UnityEngine;

public class FallingObstacles : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    public float maxDistance;

    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance (player.position, transform.position) < maxDistance){
            rb.useGravity = true;
        }
        
    }
}
