using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovSpeed;
    public Transform targetTR;

    public Transform upTarget;
    public Transform downTarget;
    public Transform leftTarget;
    public Transform rightTarget;

    public GameObject MovibleDer;
    public GameObject MovibleIzq;
    public GameObject MovibleFrente;
    public GameObject MovibleDetras;

    void Update()
    {
        var step = MovSpeed * Time.deltaTime;

        //Si apretas W y existe un valor en la variable Transform upTarget, iguala la posicion del casillero target al targetTR
        //Así con cada dirección
        if (Input.GetKeyDown(KeyCode.W) && upTarget)
        {
            targetTR = upTarget;
            downTarget = null;
            leftTarget = null;
            rightTarget = null;

        }

        else if (Input.GetKeyDown(KeyCode.W) && MovibleFrente)
        {
            
        }

        if (Input.GetKeyDown(KeyCode.S) && downTarget)
        {
            targetTR = downTarget;
            upTarget = null;
            leftTarget = null;
            rightTarget = null;

        }

        if (Input.GetKeyDown(KeyCode.A) && leftTarget)
        {
            targetTR = leftTarget;
            downTarget = null;
            upTarget = null;
            rightTarget = null;

        }

        if (Input.GetKeyDown(KeyCode.D) && rightTarget)
        {
            targetTR = rightTarget;
            downTarget = null;
            leftTarget = null;
            upTarget = null;

        }

        //El MoveTowards me pide una posición inicial, una posición final y una velocidad, en ese orden
        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);
    }

    void OnTriggerEnter (Collider other)
    {

        // Si el player se para encima de contra un objeto con el tag "Casillero", agarra los targets de ese casillero y se los guarda en los que se crearon al principio
        if (other.gameObject.tag == "Casillero")
        {
            //TargetManager es una referencia al script del casillero que estoy "triggereando", para llamarlo y acceder a sus variables públicas, que después voy a guardar en "tm"
            TargetManager tm = other.gameObject.GetComponent<TargetManager>();
            upTarget = tm.upTarget;
            downTarget = tm.downTarget;
            rightTarget = tm.rightTarget;
            leftTarget = tm.leftTarget;

            MovibleDer = tm.MovibleDer;
            MovibleIzq = tm.MovibleIzq;
            MovibleFrente = tm.MovibleFrente;
            MovibleDetras = tm.MovibleDetras;

            tm.PlayerPos = !tm.PlayerPos;
        }
    }

    void OnTriggerExit(Collider other)
    {
        TargetManager tm = other.gameObject.GetComponent<TargetManager>();

        tm.PlayerPos = !tm.PlayerPos;
    }
}