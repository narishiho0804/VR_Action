using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMove : MonoBehaviour
{
    public Transform leftHandTransform; // �����Transform��Inspector���犄�蓖�Ă�
    public Transform rightHandTransform; // �E���Transform��Inspector���犄�蓖�Ă�
    public Transform hmdTransform; // HMD��Transform��Inspector���犄�蓖�Ă�

    public GameObject cameraRig; // CameraRig�I�u�W�F�N�g��Inspector���犄�蓖�Ă�
    public float movementSpeed = 1.0f; // �ړ����x
    public float handMovementThreshold = 0.05f; // ��̓����̂������l

    private Vector3 previousLeftHandPosition;
    private Vector3 previousRightHandPosition;
    private bool isLeftHandMoving;
    private bool isRightHandMoving;

    private Rigidbody rb;

    private bool flg;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        flg = false;

        // �����ʒu���L�^
        previousLeftHandPosition = leftHandTransform.position;
        previousRightHandPosition = rightHandTransform.position;
    }

   

    public void OnStart()
    {
        flg = true;
        
        
    }

    public void OnEnd()
    {
        flg = false;
        
        
    }
    private void Update()
    {
        if (flg)
        {
            Vector3 currentLeftHandPosition = leftHandTransform.position;
            Vector3 currentRightHandPosition = rightHandTransform.position;
            Vector3 hmdForward = Quaternion.Euler(0, hmdTransform.eulerAngles.y, 0) * Vector3.forward;

            // ���E�̎�̑O��̓����𔻒�
            isLeftHandMoving = IsHandMoving(currentLeftHandPosition, previousLeftHandPosition);
            isRightHandMoving = IsHandMoving(currentRightHandPosition, previousRightHandPosition);

            // ���݂Ɏ肪�����Ă��邩�𔻒�
            if (isLeftHandMoving != isRightHandMoving)
            {
                // HMD�̌����Ă�������ɐ����ړ�
                //cameraRig.transform.position += hmdForward * movementSpeed * Time.deltaTime;
                rb.AddForce(hmdForward * movementSpeed, ForceMode.Impulse);
            }

            // ���݂̎�̈ʒu���X�V
            previousLeftHandPosition = currentLeftHandPosition;
            previousRightHandPosition = currentRightHandPosition;

           
        }
        bool IsHandMoving(Vector3 currentHandPosition, Vector3 previousHandPosition)
        {
            // ��̓������������l���傫�����𔻒�
            return (currentHandPosition - previousHandPosition).magnitude > handMovementThreshold;
        }
    }
}

