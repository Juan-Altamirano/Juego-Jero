using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImgMan : MonoBehaviour
{
    public Text txtCoins;
    // Start is called before the first frame update
    void Start()
    {
        txtCoins.text = "Coins Obtenidas: " + PlayerPrefs.GetInt("Coins").ToString() + "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Prueba 1");
        }
    }
}
