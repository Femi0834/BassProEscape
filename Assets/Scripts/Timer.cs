using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float timeAmount = 0;
    public Text timeText;


    // Update is called once per frame
    void Update() {
        timeAmount += Time.deltaTime;
        timeText.text = "Time: " + timeAmount.ToString();
        int timeAmountInt = (int)timeAmount;
        PlayerPrefs.SetInt("timer",timeAmountInt);
    }
}
