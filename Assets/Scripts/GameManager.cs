using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// ���̏o������
    /// </summary>
    [SerializeField]
    private GameObject kenPrefab; // ����Prefab

    [SerializeField]
    private GameObject Ken;

    [SerializeField]
    private GameObject ToolObject; // ��̃I�u�W�F�N�g

    [SerializeField]
    private Transform respawnKen; // ���X�|�[������ꏊ

    private bool isDetection; // ���m����bool

    void Start()
    {
        isDetection = false; // ���m��false�ɂ���
    }


    public void GoodSelected()
    {
        isDetection = true;

        if (isDetection)
        {
            // ���X�|�[���@�ʒu��ύX���ČĂ΂ꂽ�烊�X�|�[��������
            Ken.gameObject.transform.position = respawnKen.transform.position;



            //�@�傫���ύX���ďo��������
            kenPrefab.gameObject.transform.localScale = new Vector3(10f, 20f, 15f);

        }


        //�@�o�������I�u�W�F�N�g��ToolObject�̎q�ɂ���
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
