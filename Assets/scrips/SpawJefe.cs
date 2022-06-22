using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawJefe : MonoBehaviour
{
    public float tiempo;
    public Transform canon;
    public GameObject murcielago;
    public Mv movement;
    public float tiempo2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >= 138)
        {
            GameObject go = Instantiate(murcielago, canon.transform.position, canon.transform.rotation);
            tiempo = 0;
            Destroy(go, 30f);

        }
        tiempo2 = tiempo2 + Time.deltaTime;
        if (tiempo2 >= 170)
        {
            gameObject.SetActive(false); 
        }
    }
}
