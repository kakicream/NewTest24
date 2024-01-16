using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    private GameObject obj1, obj2;
    
    private void Awake()
    {
        obj1 = GameObject.Find("TestCube");
        obj1.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        //obj1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        obj1.GetComponent<Renderer>().material.color = Color.red;

        obj2 = GameObject.Find("TestCapsule");
        obj2.transform.position = new Vector3(-0.75f, 2.0f, 0.0f);
        //obj2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        obj2.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void Start() 
    {
        
    }

    void Update()
    {
        obj1.transform.Rotate(xAngle*Time.deltaTime, yAngle*Time.deltaTime, zAngle*Time.deltaTime, Space.Self);
        obj2.transform.Rotate(xAngle*Time.deltaTime, yAngle*Time.deltaTime, zAngle*Time.deltaTime, Space.World);
    }
}
