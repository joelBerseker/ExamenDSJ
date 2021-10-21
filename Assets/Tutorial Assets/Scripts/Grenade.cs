using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float tiempo = 4f;
    public GameObject prefabExplosion;
    public Intentos intento;
    float momentoExplosion;
    void Start()
    {
        momentoExplosion = Time.time + tiempo;
        intento= GameObject.FindGameObjectWithTag("GameController").GetComponent<Intentos>();;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time> momentoExplosion){
            Explosion();
        }
    }
    void Explosion(){
        Destroy(gameObject);
        intento.Fallo();
        Instantiate(prefabExplosion,transform.position,transform.rotation);
        Instantiate(gameObject,new Vector3(-5.46f,-0.78f,0),transform.rotation);
        
    }
}
