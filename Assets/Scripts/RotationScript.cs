using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Çxé≤Ç…âÒì]Ç∑ÇÈ
        this.transform.Rotate(new Vector3(0,45,0) * Time.deltaTime);

        //// DOTweenÇ≈è„â∫Ç…ìÆÇ©Ç∑
        //this.transform.DOMove(new Vector3(0f, 5f, 0f),1f).SetLoops(-1);
    }
}
