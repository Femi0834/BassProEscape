using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeTimer : MonoBehaviour
{
    public int time;

    public Text timeG;
    // Start is called before the first frame update
    void Start() {
        if(PlayerPrefs.HasKey("timer")){
            time = PlayerPrefs.GetInt("timer");
        }

        timeG.text = time.ToString("Your score is " + time);
    }

    // Update is called once per frame
    void Update() {}
}