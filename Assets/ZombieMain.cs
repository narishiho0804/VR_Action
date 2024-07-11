using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMain : MonoBehaviour
{
    private Transform target;
    private float sphereSpeed = 3.0f;
    
    bool P = false;

    void Start()
    {
        //target = GameObject.Find("PlayerCollider");
    }

    void Update()
    {
        if (P)
        {
            
            transform.LookAt(target.transform);
            transform.position += transform.forward * sphereSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            P = true;
            target= other.gameObject.GetComponent<Transform>();
        }
    }
}