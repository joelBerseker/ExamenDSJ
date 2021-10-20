using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CupNew : MonoBehaviour
{


    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene("FINAL");
        
    }
}
