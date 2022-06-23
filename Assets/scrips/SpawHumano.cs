using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawHumano : MonoBehaviour
{
   
    float numero;
    public GameObject murcielago;
    public float tiempo = 0;
    public float tiempo2 = 0;
    Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numero = Random.Range(-2f, 3f);

        tiempo = tiempo + Time.deltaTime;
        if (tiempo >= 2)
        {
            posicion = transform.position;
            posicion.x = numero;
            GameObject go = Instantiate(murcielago,posicion, transform.rotation);

            Destroy(go, 30f);
            tiempo = -4;
        }
        tiempo2 = tiempo2 + Time.deltaTime;
        if (tiempo2 >= 136)
        {
            gameObject.SetActive(false);
        }
    }
}
