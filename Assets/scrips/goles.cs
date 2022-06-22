using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goles : MonoBehaviour
{
    public float tiempo = 0;
    public Transform canon;
    public GameObject murcielago;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >=4)
        {
            GameObject go = Instantiate(murcielago, canon.transform.position, canon.transform.rotation);
            Destroy(go, 35f);
            tiempo = -2;
        }
        

    }
}

