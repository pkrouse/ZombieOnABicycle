using UnityEngine;

public class Anchor : MonoBehaviour
{
    [SerializeField] Transform toPin;
    void Update()
    {
        toPin.position = transform.position;
    }
}
