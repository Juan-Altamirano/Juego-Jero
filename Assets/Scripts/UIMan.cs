using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMan : MonoBehaviour
{
    public Text txt_time;

    float NotFlooredTime;
    string tiemppoo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiemppoo = Mathf.Floor(Time.time).ToString();
        txt_time.text = tiemppoo;

        NotFlooredTime = Time.time;
    }
}