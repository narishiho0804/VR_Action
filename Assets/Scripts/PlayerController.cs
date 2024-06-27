using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Tooltip("��������I�u�W�F�N�g")]
    private GameObject _prefab;

    [SerializeField, Tooltip("���m���Ă��邩�̊m�F")]
    private bool isDetection;

    public GameObject ToolObject;

    [SerializeField]
    private Transform respawnKen;

    //[SerializeField, Tooltip("�����ɏo�������ʒu")]
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
            // ���X�|�[���@�ʒu��ύX���ČĂ΂ꂽ�烊�X�|�[��������
            _prefab.gameObject.transform.position = respawnKen.transform.position;

            //_prefab.gameObject.transform.position;

            //�@�傫���ύX���ďo��������
            _prefab.gameObject.transform.localScale = new Vector3(10f, 20f, 15f);
        }

        //�@�o�������I�u�W�F�N�g��ToolObject�̎q�ɂ���
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
    