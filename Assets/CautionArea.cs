using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CautionArea : MonoBehaviour
{
    private GameObject target;
    private float sphereSpeed = 3.0f;

    void Start()
    {
        target = GameObject.Find("Cube");
    }

    void Update()
    {
        if (target.GetComponent<CubeMove>().invaded == true)
        {
            GetComponent<Renderer>().material.color = Color.red;
            transform.LookAt(target.transform);
            transform.position += transform.forward * sphereSpeed * Time.deltaTime;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
