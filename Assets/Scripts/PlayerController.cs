using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovSpeed;
    public bool contacto = false;

    public GameObject obstaculo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (contacto) { }

            else if (contacto == false)
            {
                transform.position += new Vector3(MovSpeed, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (contacto) { }

            else if (contacto == false)
            {
                transform.position -= new Vector3(MovSpeed, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (contacto) { }

            else if (contacto == false)
            {
                transform.position -= new Vector3(0, 0, MovSpeed);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (contacto) { }

            else if (contacto == false)
            {
                transform.position += new Vector3(0, 0, MovSpeed);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstaculo" || col.gameObject.name == "Pared")
        {
            contacto = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Obstaculo")
        {
            contacto = false;
        }
    }
}
