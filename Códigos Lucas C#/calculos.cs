using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculos : MonoBehaviour
{

    int num1 = 5;
    int num2 = 5;
    int soma, sub, mult, div;

    // Start is called before the first frame update
    void Start()
    {
    // Soma
    soma = num1 + num2;
    print(soma);

    // Subtração
    sub = num1 - num2;
    print(sub);

    // Multiplicação
    mult = num1 * num2;
    print(mult);

    // Divisão
    div = num1 / num2;
    print(div);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
