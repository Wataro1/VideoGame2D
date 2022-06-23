using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw2 : MonoBehaviour
{
    public float tiempo = 0;
    public Transform canon;
    public GameObject murcielago;
    public float tiempo2 = 0;
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

            Destroy(go, 40f);
            tiempo = -35;
        }
        tiempo2 = tiempo2 + Time.deltaTime;
        if (tiempo2 >= 136)
        {
            gameObject.SetActive(false);
        }
    }
}
