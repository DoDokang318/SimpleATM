using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{

    [SerializeField]
    Button BtnLogin;
    void Start()
    {
        BtnLogin.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainScene");

        });
    }


}
