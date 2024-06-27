using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 剣の出現する
    /// </summary>
    [SerializeField]
    private GameObject kenPrefab; // 剣のPrefab

    [SerializeField]
    private GameObject Ken;

    [SerializeField]
    private GameObject ToolObject; // 空のオブジェクト

    [SerializeField]
    private Transform respawnKen; // リスポーンする場所

    private bool isDetection; // 検知するbool

    void Start()
    {
        isDetection = false; // 検知をfalseにする
    }


    public void GoodSelected()
    {
        isDetection = true;

        if (isDetection)
        {
            // リスポーン　位置を変更して呼ばれたらリスポーンをする
            Ken.gameObject.transform.position = respawnKen.transform.position;



            //　大きさ変更して出現させる
            kenPrefab.gameObject.transform.localScale = new Vector3(10f, 20f, 15f);

        }


        //　出現したオブジェクトをToolObjectの子にする
        Ken.transform.parent = ToolObject.transform;

        Ken.transform.localRotation = Quaternion.identity;
        Ken.transform.localPosition = Vector3.zero;
    }


    public void NoSelected()
    {
        isDetection = false;

        if (!isDetection)
        {

        }
    }
}
