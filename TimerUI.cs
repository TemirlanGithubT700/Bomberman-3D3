using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float elapsedTime=90;

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime > 0)
        {
            elapsedTime -= Time.deltaTime;
        }
        else if(elapsedTime < 0)
        {
            elapsedTime = 0;
        }
        int minutes=Mathf.FloorToInt(elapsedTime/60);
        int seconds=Mathf.FloorToInt(elapsedTime%60);
        timerText.text = string.Format("{00:00}:{01:00}",minutes,seconds);
    }
}
