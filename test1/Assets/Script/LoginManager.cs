using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{

    public GameObject LoginView;

    public TMP_InputField inputId;
    public TMP_InputField inputPw;
    public TMP_Text popUpText;
    public Button LoginButton;
    public Button CloseButton;

    private string user = "user";
    private string password = "1234";
    private string loginSuccess = "Login success!";
    private string loginFailure = "No matching information found.";
    public void LoginButtonClick()
    {
        if (inputId.text == user && inputPw.text == password)
        {
            Debug.Log(loginSuccess);
            popUpText.text = loginSuccess;
        }
        else
        {
            Debug.Log(loginFailure);
            popUpText.text = loginFailure;
        }
    }
    public void CloseButtonClick()
    {
        if(popUpText.text == loginSuccess)
        {
            SceneManager.LoadScene("DemoDay");
        }
    }
}
