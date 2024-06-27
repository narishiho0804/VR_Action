using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    OVRInput.Controller LeftCon;
    OVRInput.Controller RightCon;
    void Start()
    {
        LeftCon = OVRInput.Controller.LTouch;
        RightCon = OVRInput.Controller.RTouch;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 accLeft = OVRInput.GetLocalControllerAcceleration(LeftCon);
        Vector3 accRight = OVRInput.GetLocalControllerAcceleration(RightCon);

        float walkSpeed = 10;
        float moveSpeed;
        moveSpeed = accLeft.y + accRight.y;
        if (moveSpeed <= -walkSpeed || moveSpeed >= walkSpeed)
        {
            //var moveDirect = PlayerCamera.transform.rotation.eulerAngles.y;
            //var moveQuate = Quaternion.Euler(0, moveDirect, 0);
            //transform.position += (moveQuate * Vector3.forward).normalized * Time.deltaTime;
        }

    }
}
