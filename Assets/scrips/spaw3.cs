using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw3 : MonoBehaviour
{
    public float tiempo;
    public Transform canon;
    public GameObject murcielago;
    public Mv movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >=20)
        {
            GameObject go = Instantiate(murcielago, canon.transform.position, canon.transform.rotation);
            tiempo = 4;
            Destroy(go, 20f);

        }
      
       
    }
}
