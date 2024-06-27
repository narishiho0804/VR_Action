using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMove : MonoBehaviour
{
    public Transform leftHandTransform; // 左手のTransformをInspectorから割り当てる
    public Transform rightHandTransform; // 右手のTransformをInspectorから割り当てる
    public Transform hmdTransform; // HMDのTransformをInspectorから割り当てる

    public GameObject cameraRig; // CameraRigオブジェクトをInspectorから割り当てる
    public float movementSpeed = 1.0f; // 移動速度
    public float handMovementThreshold = 0.05f; // 手の動きのしきい値

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

        // 初期位置を記録
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

            // 左右の手の前後の動きを判定
            isLeftHandMoving = IsHandMoving(currentLeftHandPosition, previousLeftHandPosition);
            isRightHandMoving = IsHandMoving(currentRightHandPosition, previousRightHandPosition);

            // 交互に手が動いているかを判定
            if (isLeftHandMoving != isRightHandMoving)
            {
                // HMDの向いている方向に水平移動
                //cameraRig.transform.position += hmdForward * movementSpeed * Time.deltaTime;
                rb.AddForce(hmdForward * movementSpeed, ForceMode.Impulse);
            }

            // 現在の手の位置を更新
            previousLeftHandPosition = currentLeftHandPosition;
            previousRightHandPosition = currentRightHandPosition;

           
        }
        bool IsHandMoving(Vector3 currentHandPosition, Vector3 previousHandPosition)
        {
            // 手の動きがしきい値より大きいかを判定
            return (currentHandPosition - previousHandPosition).magnitude > handMovementThreshold;
        }
    }
}

