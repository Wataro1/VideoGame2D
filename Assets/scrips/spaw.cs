using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw : MonoBehaviour
{
    // Respaw del enemigo
    public Transform canon;
    public GameObject murcielago;
    public float tiempo = 0;
    public float tiempo2 = 0;
   
    // Update is called once per frame
     void Update()
     {
        
        // respaw cada cierto tiempo 
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >=2)
        {
            GameObject go = Instantiate(murcielago, canon.transform.position, canon.transform.rotation);
            
            Destroy(go, 10f);
            tiempo = 0;
        }
        tiempo2 = tiempo2 + Time.deltaTime;
        if(tiempo2>=136)
        {
            gameObject.SetActive(false);
        }
     }
    
}

