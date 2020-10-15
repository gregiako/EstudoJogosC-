using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incrementeEdecremento : MonoBehaviour
{

    int resultado = 100;
    int valor = 100;

    // Start is called before the first frame update
    void Start()
    {
        print(resultado);
        // Incremento
        int preIncremento = ++resultado; // Pré-incremento
        print(preIncremento);

        int posIncremento = resultado++; // Pós-incremento
        print(posIncremento);

        // Decremento
        int preDecremento = --valor; // Pré-decremento
        print(preDecremento);

        int posDecremento = valor--; // Pós-decremento
        print(posDecremento);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
