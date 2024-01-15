using UnityEngine;

public class RoadRunner : MonoBehaviour
{
    private float speed = -5f;
    private Vector3 direction = new Vector3(0, 0, 1);
    
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
