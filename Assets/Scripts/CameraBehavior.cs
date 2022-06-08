using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    //Los 4 Transforms son para indicar la posición a la que tiene que moverse la cámara

    //Al final terminé haciendo lo mismo que el player con los casilleros, en el que se guardan 2 de las posibles posiciones
    public Transform SigPos;
    public Transform PrevPos;

    public Transform CurrentTgt;

    int grados;
    // Start is called before the first frame update
    void Start()
    {
        grados = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Si el número de grados que rota es positivo, la cámara rota hacia 
        //la derecha, y si es negativo rota hacia la izquierda
        if (Input.GetKeyDown(KeyCode.K) && SigPos)
        {
            CurrentTgt = SigPos;
            SigPos = null;
            PrevPos = null;
            
            while (grados <= 91)
            {
                transform.eulerAngles -= new Vector3 (0, 5, 0);
                grados += 5;
            }
        }

        if (Input.GetKeyDown(KeyCode.L) && PrevPos)
        {
            transform.eulerAngles -= new Vector3(0, 2, 0);
        }

        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CamPos")
        {
            CamPosition cp = col.gameObject.GetComponent<CamPosition>();
            SigPos = cp.SigPos;
            PrevPos = cp.PrevPos;
        }
    }
}
