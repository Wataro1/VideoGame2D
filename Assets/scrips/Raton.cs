using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raton : MonoBehaviour
{
    public Mv movement;
    public Transform jugador;
    public float rango = 60;
    private float distance;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, jugador.position);
        movement.Move(-1, 0);
        tiempo = tiempo + Time.deltaTime;
        if (tiempo >= 1)
        {
            movement.Move(0, 1);
        }
        if (tiempo >= 2)
        {
            movement.Move(0, -1);
        }
        if (tiempo >= 3)
        {
            movement.Move(1, 0);
        }
        if (tiempo >= 4)
        {
            movement.Move(-1, 0);
            tiempo = 0; 
        }
        
    }
}
