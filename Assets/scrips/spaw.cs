using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw : MonoBehaviour
{
    // Respaw del enemigo
 
    public GameObject murcielago;
    public float tiempo = 0;
    public float tiempo2 = 0;
    Vector3 posicion;
    public float numero;

    // Update is called once per frame
    void Update()
     {
        numero = Random.Range(-2f, 3f);
        // respaw cada cierto tiempo 
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >=1)
        {
           
            posicion = transform.position;
            posicion.x = numero;
            GameObject go = Instantiate(murcielago, posicion, transform.rotation);


            Destroy(go, 10f);
            tiempo = -2;
        }
        tiempo2 = tiempo2 + Time.deltaTime;
        if(tiempo2>=136)
        {
            gameObject.SetActive(false);
        }
     }
    
}

