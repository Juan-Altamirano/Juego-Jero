using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsRomp : MonoBehaviour
{

    // public material Azul
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }

        //objeto.GetComponent<Renderer>.material == Azul;
    }
}
