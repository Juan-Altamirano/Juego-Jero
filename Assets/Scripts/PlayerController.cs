using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovSpeed;
    public bool contactoW = false;
    public bool contactoA = false;
    public bool contactoS = false;
    public bool contactoD = false;

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
            if (contactoA) { }

            else if (contactoA == false)
            {
                transform.position += new Vector3(MovSpeed, 0, 0);
                contactoA = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (contactoD) { }

            else if (contactoD == false)
            {
                transform.position -= new Vector3(MovSpeed, 0, 0);
                contactoD = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (contactoW) { }

            else if (contactoW == false)
            {
                transform.position -= new Vector3(0, 0, MovSpeed);
                contactoW = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (contactoS) { }

            else if (contactoS == false)
            {
                while (contactoS)
                {
                    transform.position += new Vector3(0, 0, MovSpeed);
                }
                contactoS = true;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstaculo" || col.gameObject.name == "Pared")
        {

        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Obstaculo" || col.gameObject.name == "Pared")
        {
            
        }
    }

    void Movement()
    {
        
    }
}
