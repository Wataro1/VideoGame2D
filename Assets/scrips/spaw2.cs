using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw2 : MonoBehaviour
{
    public float tiempo;
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
        if (tiempo >= 7)
        {
            GameObject go = Instantiate(murcielago, canon.transform.position, canon.transform.rotation);

            Destroy(go, 10f);
            tiempo = -35;
        }
    }
}
