using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Tooltip("生成するオブジェクト")]
    private GameObject _prefab;

    [SerializeField, Tooltip("検知しているかの確認")]
    private bool isDetection;

    public GameObject ToolObject;

    [SerializeField]
    private Transform respawnKen;

    //[SerializeField, Tooltip("そこに出したい位置")]
    //private Transform _transform;



    //[SerializeField]
    //List<GameObject> _myList = new List<GameObject>();

    float count;

    void Start()
    {
        isDetection = false;
    }


    public void GoodSelected()
    {

        isDetection = true;


        if (isDetection)
        {
            // リスポーン　位置を変更して呼ばれたらリスポーンをする
            _prefab.gameObject.transform.position = respawnKen.transform.position;

            //_prefab.gameObject.transform.position;

            //　大きさ変更して出現させる
            _prefab.gameObject.transform.localScale = new Vector3(10f, 20f, 15f);
        }

        //　出現したオブジェクトをToolObjectの子にする
        _prefab.transform.parent = ToolObject.transform;
    }

    public void NoSelected()
    {
        isDetection = false;

        if (isDetection == false)
        {

        }

    }
}
    