using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaList : MonoBehaviour
{
    List<int> lista = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        /*
        lista.Add(100);
        lista.Add(200);
        lista.Add(300);
        lista.Add(400);

        lista.Remove(100); // valor 100 deixa de existir e o próximo valor toma a sua posição

        print(lista.IndexOf(300)); // para saber a posição do valor 300

        print(lista[0]);*/

        for (int i = 0; i <= 9; i++)
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
