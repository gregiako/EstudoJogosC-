/*
Crie uma classe que represente um zumbi, todos seus atributos
devem ser públicos.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio7 : MonoBehaviour
{
    Zumbi objZumbi;

    // Start is called before the first frame update
    void Start()
    {
        objZumbi = new Zumbi();

        objZumbi.nome = "Morto-Vivo";
        objZumbi.dano = 350;
        objZumbi.vida = 700;

        print(objZumbi.nome);
        print(objZumbi.dano);
        print(objZumbi.vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Zumbi
{
    public string nome;
    public int dano;
    public int vida;
}
