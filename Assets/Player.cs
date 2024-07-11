using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool invaded;


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "CautionArea")
        {
            invaded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "CautionArea")
        {
            invaded = false;
        }
    }
   
}
