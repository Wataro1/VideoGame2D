using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimiGolem : MonoBehaviour
{

    public MvGolem movement;
    public Transform jugador;
    public float rango = 60;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, jugador.position);

        movement.Mov(-1, 0);

    }
}
