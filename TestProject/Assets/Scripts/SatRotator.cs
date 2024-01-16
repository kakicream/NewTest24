using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatRotator : MonoBehaviour
{
    Vector3 rotVec = new Vector3(2.0f, 6.0f, 1.2f);

    public GameObject target;
    [SerializeField]
    float distance = 5.0f;
    
    void Update()
    {
        transform.Rotate(rotVec, Space.Self);

        
        transform.position = (transform.position - target.transform.position).normalized*distance+target.transform.position;
    }
}
