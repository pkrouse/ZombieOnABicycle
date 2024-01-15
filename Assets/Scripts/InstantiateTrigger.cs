using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTrigger : MonoBehaviour
{
    [SerializeField] RoadManager roadManager;
    private void OnTriggerEnter(Collider other)
    {
        roadManager.TriggeredAt(transform);
    }
}
