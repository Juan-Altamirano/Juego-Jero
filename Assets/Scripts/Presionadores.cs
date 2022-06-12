using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presionadores : MonoBehaviour
{
    public GameObject Casillero;
    float speed;
    public Transform NextPos;

    public Transform PosDer;
    public Transform PosIzq;
    public Transform PosFrente;
    public Transform PosDetras;

    public bool CasPlyrPos;


    void Start()
    {
        speed = 5 * Time.deltaTime;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && PosFrente)
        {
            NextPos = PosFrente;
            PosIzq = null;
            PosDer = null;
            PosDetras = null;
        }

        if (Input.GetKeyDown(KeyCode.A) && PosIzq)
        {
            NextPos = PosIzq;
            PosIzq = null;
            PosDer = null;
            PosDetras = null;
        }

        if (Input.GetKeyDown(KeyCode.S) && PosDetras)
        {
            NextPos = PosDetras;
            PosIzq = null;
            PosDer = null;
            PosDetras = null;
        }

        if (Input.GetKeyDown(KeyCode.D) && PosDer)
        {
            NextPos = PosDer;
            PosIzq = null;
            PosDer = null;
            PosDetras = null;
        }

        transform.position = Vector3.MoveTowards(transform.position, NextPos.position, speed);
    }

    void OnTriggerEnter(Collider cas)
    {
        if (cas.gameObject.tag == "Casilleron't")
        {
            CasPres cp = cas.gameObject.GetComponent<CasPres>();
            Casillero = cas.gameObject;

            cp.PosDer = PosDer;
            cp.PosIzq = PosIzq;
            cp.PosFrente = PosFrente;
            cp.PosDetras = PosDetras;
        }
    }
}
