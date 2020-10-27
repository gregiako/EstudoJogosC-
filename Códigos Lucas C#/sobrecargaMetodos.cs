using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobrecargaMetodos : MonoBehaviour
{
    Calculadora calculadora;
    // Start is called before the first frame update
    void Start()
    {
        int resultadoINT;
        float resultadoFLOAT;

        calculadora = new Calculadora();

        resultadoINT = calculadora.calcular(5,5);
        resultadoFLOAT = calculadora.calcular(5.5f,5.5f);

        print(resultadoINT);
        print(resultadoFLOAT);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Calculadora
{
    public int calcular(int valor1, int valor2) {
        int resultado = valor1 + valor2;
        return resultado;
    }

    public float calcular(float valor1, float valor2) {
        float resultado = valor1 + valor2;
        return resultado;
    }
}