using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class CalenderManager : MonoBehaviour
{
    public Button[] dayButtons;

    private void Start()
    {
        DisplayCalendar();
    }

    private void DisplayCalendar()
    {
        System.DateTime currentDate = System.DateTime.Now;
        System.DateTime firstDayOfMonth = new System.DateTime(currentDate.Year, currentDate.Month, 1);
        System.DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

        for (int i = 0; i < dayButtons.Length; i++)
        {
            Button dayButton = dayButtons[i];
            TMP_Text buttonText = dayButton.GetComponentInChildren<TMP_Text>();

            if (i >= (int)firstDayOfMonth.DayOfWeek && i - (int)firstDayOfMonth.DayOfWeek < lastDayOfMonth.Day)
            {
                int dayNumber = i - (int)firstDayOfMonth.DayOfWeek + 1;
                dayButton.interactable = true;
                buttonText.text = dayNumber.ToString();
            }
            else
            {
                dayButton.interactable = false;
                buttonText.text = "";
            }

            if (i % 7 == 0 || i % 7 == 6)
            {
                dayButton.GetComponent<Image>().color = Color.gray;
            }
        }
    }
}

