using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Resetear : MonoBehaviour
{
   private Scene miEscena;
   
    // Start is called before the first frame update
    void Start()
    {
        miEscena = SceneManager.GetActiveScene();
       
    }


    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnMouseDown()
    {   
        SceneManager.LoadScene("Game");
    }
}
