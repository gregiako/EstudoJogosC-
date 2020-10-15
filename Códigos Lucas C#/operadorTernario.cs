using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadorTernario : MonoBehaviour
{

    int moedasHeroi = 150;
    int precoVida = 100;
    string resultado;

    // Start is called before the first frame update
    void Start()
    {
        //CONDIÇÃO? TRUE:FALSE
        resultado = (moedasHeroi >= precoVida)?"Você pode comprar uma vida.":"Você não pode comprar vida.";
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
