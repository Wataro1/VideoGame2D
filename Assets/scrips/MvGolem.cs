using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvGolem : MonoBehaviour
{
    public float spedMovement;
    public Vector2 direcion;
    public float vidaMaxima = 2;
    public float vidaActual;


    void Start()
    {
        vidaActual = vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Mov(float Vertical, float Horizontal)
    {

        direcion.x = Horizontal;
        direcion.y = Vertical;

        direcion = transform.TransformDirection(direcion);
        transform.Translate(direcion * Time.deltaTime * spedMovement);
    }
    private void OnMouseDown()
    {
        float daño = 1;
        vidaActual = vidaActual - daño;
        if (vidaActual == 0)
        {
            //Desativar enemigos 
            gameObject.SetActive(false);
        }
    }
}
