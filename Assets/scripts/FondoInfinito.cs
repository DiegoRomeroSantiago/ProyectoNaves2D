using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoInfinito : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float anchoImagen;
    private Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = gameObject.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        float espacioRecorrido = velocidad * Time.time;
        float resto = espacioRecorrido % anchoImagen;

        transform.position = posicionInicial + new Vector3(-1, 0, 0) * resto;


    }
}
