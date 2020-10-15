using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadoresReduzidos : MonoBehaviour
{

    int valor = 100;
    int valor2 = 100;

    // Start is called before the first frame update
    void Start()
    {
        print(valor);
        
        valor = valor + 2; // Operação comum
        print(valor);

        valor2 += 2; // Operação reduzida (pode ser feita com qualquer operação: multiplicação etc)
        print(valor2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
