using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidas : MonoBehaviour
{
    public float vidaMaxima = 5;
    public float vidaActual;
    float daño = 1;
    public float vida;
    void Start()
    {
        vidaActual = vidaMaxima;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "golem")
         vidaActual = vidaActual - daño;
    }

    public void DamageLifes()
    {
        vidaActual = vidaActual - daño;
    }

}
