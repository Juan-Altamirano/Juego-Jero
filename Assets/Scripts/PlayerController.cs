using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float MovSpeed;
    public Transform targetTR;

    public Time tiempo;

    public Transform upTarget;
    public Transform downTarget;
    public Transform leftTarget;
    public Transform rightTarget;

    public int CoinAmount;
    AudioSource cling;
    public int movs;

    //public GameObject MovibleDer;
    //public GameObject MovibleIzq;
    //public GameObject MovibleFrente;
    //public GameObject MovibleDetras;

    void Start()
    {
        CoinAmount = 0;

        cling = GetComponent<AudioSource>();
    }

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

            CuentaDeMovs();
        }

        //else if (Input.GetKeyDown(KeyCode.W) && MovibleFrente)
        //{
            
        //}

        if (Input.GetKeyDown(KeyCode.S) && downTarget)
        {
            targetTR = downTarget;
            upTarget = null;
            leftTarget = null;
            rightTarget = null;

            CuentaDeMovs();
        }

        if (Input.GetKeyDown(KeyCode.A) && leftTarget)
        {
            targetTR = leftTarget;
            downTarget = null;
            upTarget = null;
            rightTarget = null;

            CuentaDeMovs();
        }

        if (Input.GetKeyDown(KeyCode.D) && rightTarget)
        {
            targetTR = rightTarget;
            downTarget = null;
            leftTarget = null;
            upTarget = null;

            CuentaDeMovs();
        }

        //El MoveTowards me pide una posición inicial, una posición final y una velocidad, en ese orden
        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);
    }

    //Esta función es medio inútil, solo recordé que para los botones había que seleccionar una función del script que le tirás, y lo confundí con lo que realmente tenía que hacer
    public void CuentaDeMovs()
    {
        if (movs == 0)
        {

        }

        else
        {
            movs--;
        }
    }

    void OnTriggerEnter(Collider other)
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

            //MovibleDer = tm.MovibleDer;
            //MovibleIzq = tm.MovibleIzq;
            //MovibleFrente = tm.MovibleFrente;
            //MovibleDetras = tm.MovibleDetras;

            //tm.PlayerPos = !tm.PlayerPos;
        }
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Coin")
        {
            cling.Play();
        }

        //Por alguna razón si pongo el "cling.Play();" en el script de la moneda, no toma en cuenta la colisión y no hace que desaparezca la coin ni se instancien las "partículas"
    }

    //void OnTriggerExit(Collider other) - Idea descartada
    //{
    //    TargetManager tm = other.gameObject.GetComponent<TargetManager>();

    //    tm.PlayerPos = !tm.PlayerPos;
    //}
}