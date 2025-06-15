using UnityEngine;

public class RotatingObstacles : MonoBehaviour
{
    public Vector3 RotatingAmount;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotatingAmount * Time.deltaTime);
        
    }
}
