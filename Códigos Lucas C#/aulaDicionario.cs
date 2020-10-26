using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaDicionario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string,string> vilao = new Dictionary<string,string>();

        // Adicionar os dados no dicionário.
        vilao.Add("Matador","O primeiro vilão.");
        vilao.Add("Atirador","O segundo vilão.");

        // Remover os dados no dicionário.
        // vilao.Remove("Matador");

        foreach (string chave in vilao.Keys)
        {
            print(vilao[chave]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
