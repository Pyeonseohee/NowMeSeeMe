using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegisterManager : MonoBehaviour
{
    public GameObject RegisterView;

    public TMP_InputField inputId;
    public TMP_InputField inputName;
    public TMP_InputField inputPw;
    public TMP_InputField confirmPw;

    public TMP_Text popUpText;
    public Button RegisterButton;

    public void RegisterButtonClick()
    {
        if(inputPw.text == confirmPw.text)
        {
            Debug.Log("success");
            popUpText.text = "Login success!";
        }
        else
        {
            Debug.Log("No");
            popUpText.text = "Password does not match.";
        }
    }
}
