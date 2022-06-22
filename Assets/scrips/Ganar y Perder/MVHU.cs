using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVHU : MonoBehaviour
{
    public float spedMovement;
    public Vector2 direcion;
    public GameObject Mapa;
    public GameObject Padre;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Move(float Vertical, float Horizontal)
    {

        direcion.x = Horizontal;
        direcion.y = Vertical;

        direcion = transform.TransformDirection(direcion);
        transform.Translate(direcion * Time.deltaTime * spedMovement);
    }
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        Mapa.SetActive(false);
        Padre.SetActive(false);
    }
}
