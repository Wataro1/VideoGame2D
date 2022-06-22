using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float vidaMaxima = 5;
    public float vidaActual;
    float daño = 1;
    public float vida;
    public GameObject Padre;
    public GameObject Vida;
    public GameObject Vida1;
    public GameObject Vida2;
    public GameObject Vida3;
    public GameObject Vida4;
    void Start()
    {
        vidaActual = vidaMaxima;
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "golem")
        {
            vidaActual = vidaActual - daño;
        }
        if(vidaActual==4)
        {
            Vida.gameObject.SetActive(false);
        }
        if(vidaActual==3)
        {
            Vida1.gameObject.SetActive(false);
        }
        if(vidaActual==2)
        {
            Vida2.gameObject.SetActive(false);
        }
        if(vidaActual==1)
        {
            Vida3.gameObject.SetActive(false);
        }
        if(vidaActual==0)
        {
            
          gameObject.SetActive(false);
          Padre.gameObject.SetActive(false);
          Vida4.gameObject.SetActive(false);
        }
    }

 

}
