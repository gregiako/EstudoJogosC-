/*
Faça uma soma usando os valores inteiros de duas variáveis (valor1 e
valor2), coloque o resultado em uma terceira variável (result) e exiba
no console seu resultado.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio2 : MonoBehaviour
{
    public int valor1 = 10, valor2 = 10, result;

    // Start is called before the first frame update
    void Start()
    {
        result = valor1 + valor2;

        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
