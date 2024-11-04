using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] public float velocidad;
    [SerializeField] private float vidas;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1,0,0).normalized * velocidad * Time.deltaTime);
    }
    public  void RecibirDaño(float dañoRecibido)
    {
        vidas -= dañoRecibido;
        anim.SetTrigger("blink");
        if (vidas < 0)
        {
            Destroy(this.gameObject);
        }
            
    }
 
}
