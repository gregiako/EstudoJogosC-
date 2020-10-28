/*
Crie uma lista contendo 10 elementos de qualquer tipo depois
imprima cada elemento no console.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio6 : MonoBehaviour
{
    List<int> lista = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            lista.Add(i);
            
        }
        foreach (int valores in lista)
        {
            print(valores);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
