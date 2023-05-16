using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatManager : MonoBehaviour
{
    public TMP_Text ChatText;
    public string writerText = "";
    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키
    bool isButtonClicked = false;
    IEnumerator NormalChat(string narration)
    {
        int a;
        writerText = "";

        // 텍스트 타이핑 효과
        for(a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //키를 다시 누를 떄 까지 무한정 대기
        while (true)
        {
            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextPractice());
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var element in skipButton) // 버튼 검사
        {
            if (Input.GetKeyDown(element))
            {
                isButtonClicked = true;
            }
        }
    }

    IEnumerator TextPractice()
    {
        yield return StartCoroutine(NormalChat("Hello, Nice to meet you!"));
    }
}
