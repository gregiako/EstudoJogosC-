using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaMetodos : MonoBehaviour
{
    Metodos somar;
    // Start is called before the first frame update
    void Start()
    {
        int valorRetorno;
        somar = new Metodos();
        valorRetorno =  somar.soma();

        print(valorRetorno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Metodos
{
    public int soma() {
        int valor1 = 10;
        int valor2 = 10;
        int resultado = valor1 + valor2;

        return resultado;
    }
}
