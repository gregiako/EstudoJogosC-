using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaMatriz : MonoBehaviour
{
    int[,] matriz = new int[2,2];
    int valor = 1;
    // Start is called before the first frame update
    void Start()
    {
       /* matriz[0,0] = 1;
        matriz[0,1] = 2;
        matriz[1,0] = 3;
        matriz[1,1] = 4;

        print(matriz[0,1]);*/

        for (int linhas = 0; linhas <= 1; linhas++)
        {
            for (int colunas = 0; colunas <= 1; colunas++)
            {
                matriz[linhas,colunas] = valor;
                valor++;
            }
        }
        for (int linhas = 0; linhas <= 1; linhas++)
        {
            for (int colunas = 0; colunas <= 1; colunas++)
            {
                print(linhas + " : " + colunas + " = " + matriz[linhas,colunas]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
