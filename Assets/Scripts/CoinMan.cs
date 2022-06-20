using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMan : MonoBehaviour
{
    public Vector3 Pos;
    public GameObject prefab;

    public GameObject Casillero;

    GameObject clon;

    void Start()
    {
        Pos = Casillero.transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            PlayerController pc = col.gameObject.GetComponent<PlayerController>();
            pc.CoinAmount++;

            prefab.transform.position = Pos + new Vector3 (0, 1, 0);

            for (int i = 1; i < 7; i++)
            {
                clon = Instantiate(prefab);
                //clon.transform.position = new Vector3(Random.Range(2.4f, 2.6f), 2, Random.Range(4.4f, 4.6f)); Esto solo me servía para una moneda, mientras que el de abajo me sirve para todas
                clon.transform.position = new Vector3(Random.Range(Pos.x - 0.1f,Pos.x + 0.1f), 2, Random.Range(Pos.z - 0.1f, Pos.z + 0.1f));
                Destroy(clon, 1);
            }
        }
    }
}
