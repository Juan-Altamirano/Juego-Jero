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

    void Update()
    {
        var step = MovSpeed * Time.deltaTime;

        //Si apretas W y existe un valor en la variable Transform upTarget, 
        if (Input.GetKeyDown(KeyCode.W) && upTarget)
        {
            targetTR = upTarget;
            downTarget = null;
            leftTarget = null;
            rightTarget = null;

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

        //El MoveTowards me pide una posición inicial, una  posición final y una velocidad, en ese orden
        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);
    }
}
