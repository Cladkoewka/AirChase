using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Airplane;

    // Update is called once per frame
    void Update()
    {
        if (Airplane)
        {
            transform.position = Airplane.position;
        }
    }
}
