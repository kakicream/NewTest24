using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    Vector3 rotVec = new Vector3 (1.0f, 2.0f, 5.0f);
    
    void Update()
    {
        transform.Rotate(rotVec*Time.deltaTime, Space.Self);
    }
}
