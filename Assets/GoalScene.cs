using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            Debug.Log("“–‚½‚Á‚½");
            SceneManager.LoadScene("GameClerScene");
        }
    }
}
