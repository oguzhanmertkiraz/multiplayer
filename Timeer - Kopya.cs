using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeer : MonoBehaviour
{
    public Text TimerText2;
    private float StartTime;

    // Use this for initialization
    void Start()
    {
        StartTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - StartTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f");
        TimerText2.text = minutes + ":" + seconds;

    }
}
