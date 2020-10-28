/*
Crie um vetor para guardar 5 nomes de vilões, depois imprima no
console cada um dos nomes.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio5 : MonoBehaviour
{
    string[] nomeVilao = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        nomeVilao[0] = "Matador";
        nomeVilao[1] = "Atirador";
        nomeVilao[2] = "Esqueleto";
        nomeVilao[3] = "Cavaleiro";
        nomeVilao[4] = "Morto-Vivo";

        print(nomeVilao[0]);
        print(nomeVilao[1]);
        print(nomeVilao[2]);
        print(nomeVilao[3]);
        print(nomeVilao[4]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
