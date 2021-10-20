using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Intentos : MonoBehaviour
{
    
    public int intento = 3;
    public Text countText;
    void Start()
    {
    }

    void Update()
    {
        
        countText.text="Intento: "+intento;
        if(intento<=0){
            SceneManager.LoadScene("GAMEOVER");
        }
    }
    public void Fallo(){
        intento --;
    }
}
