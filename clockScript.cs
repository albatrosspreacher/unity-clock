using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class clockScript : MonoBehaviour
{   
    private Text textClock; 

    void Awake (){ 
        textClock = GetComponent<Text>(); //make sure you include "UnityEngine.UI" or just "UnityEngine.UI.Text"
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world!");
    }

    // Update is called once per frame
    void Update()
    {
    DateTime time = DateTime.Now; //make sure you include "System" 
    string hour = padding(time.Hour);
    string minute = padding(time.Minute);
    string second = padding(time.Second);
    textClock.text = hour + ":" + minute + ":" + second;
    }
    string padding (int n){
     return n.ToString().PadLeft(2, '0');
  }
}

