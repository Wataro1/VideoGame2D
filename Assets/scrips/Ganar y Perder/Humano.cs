using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    public Transform jugador;
    public float rango = 60;
    private float distance;
    public MVHU movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, jugador.position);

        movement.Mo(-1, 0);
    }
}
