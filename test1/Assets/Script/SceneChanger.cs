using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void loginToRegisterChange()
    {
        SceneManager.LoadScene("RegisterScene");
    }

    public void registerToLoginChange()
    {
        SceneManager.LoadScene("LoginScene");
    }

}
