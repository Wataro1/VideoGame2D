using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw : MonoBehaviour
{
    // Respaw del enemigo
    public Transform canon;
    public GameObject murcielago;
    private float tiempo = 0;
    
    void Start()
    {
        
    }

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
        
    }
    
}

