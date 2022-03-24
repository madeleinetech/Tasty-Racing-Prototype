using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerWL : MonoBehaviour
{
    public float timer = 60;
    public bool isTimerEnd = false;

    public Text timerDisplay;
    // Start is called before the first frame update
    void Start()
    {
        isTimerEnd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerEnd)
        {
            if(timer > 0)
            {
                timer -= Time.deltaTime;
                displayTime(timer);
            }
            else
            {
                Debug.Log("Game Over");
                timer = 0;
                isTimerEnd = false;
            }
        }
    }

    void displayTime(float display)
    {
        display += 1;
        float mins = Mathf.FloorToInt(display / 60);
        float secs = Mathf.FloorToInt(display % 60);
        timerDisplay.text = string.Format("{0:00}:{1:00}", mins, secs);
    }
}
