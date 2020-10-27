using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodoEstatico : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int exibirResultado = Teste.soma(5,5);

        print(exibirResultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Teste
{
    public static int soma (int valor1, int valor2) {
        int resultado = valor1 + valor2;
        return resultado;
    }
}
