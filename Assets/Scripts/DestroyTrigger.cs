using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject toDestroy = other.gameObject.transform.parent.gameObject;
        Destroy(toDestroy);
    }
}
