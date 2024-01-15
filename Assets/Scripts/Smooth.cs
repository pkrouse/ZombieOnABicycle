using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth : MonoBehaviour
{
    private float targetWeight = 0f;
    private float weight = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weight = Mathf.Lerp(weight, targetWeight, Time.deltaTime * 10f);
        if (Input.GetKeyDown(KeyCode.T))
        {
            targetWeight = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            targetWeight = 0f;
        }
    }
}
