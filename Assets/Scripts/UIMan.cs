using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMan : MonoBehaviour
{
    public Text txt_time;

    public string tiemppoo;

    void Start()
    {
        tiemppoo = Mathf.FloorToInt(Time.time).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        txt_time.text = "Tiempo tardado: " + tiemppoo;
    }
}