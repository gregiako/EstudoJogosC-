/*
Crie uma estrutura condicional que exibe a palavra Unity se, e
somente se a variável inteira (engine) for maior que 10.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio3 : MonoBehaviour
{
    public int engine = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (engine == 10)
        {
            print("Unity.");
        }
        else
        {
            print("ERRO 1001: VALOR INCORRETO OU PARÂMETRO INEXISTENTE.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
