/*
1. Crie variáveis para representar os seguintes itens:
    a. Número de vidas
    b. Número de moedas
    c. Nome
    d. Energia
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio1 : MonoBehaviour
{
    public int vidasHeroi = 10, moedasHeroi = 200, energiaHeroi = 500;
    public string nomeHeroi = "Sr. Cleidson";
    
    // Start is called before the first frame update
    void Start()
    {
        print(vidasHeroi);
        print(moedasHeroi);
        print(energiaHeroi);
        print(nomeHeroi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
