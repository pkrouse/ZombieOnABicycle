using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    [SerializeField] Transform hips;
    [SerializeField] Transform seat;
    void Start()
    {
        print("initialized the position controller");
    }

    // Update is called once per frame
    void Update()
    {
        hips.position = seat.position;
    }
}
