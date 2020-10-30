/*
Crie uma classe chamada zumbi_filho e faça com que ela herde da
classe zumbi.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio9 : MonoBehaviour
{
    ZumbiPai objZumbiPai;
    ZumbiFilho objZumbiFilho;

    // Start is called before the first frame update
    void Start()
    {
        objZumbiPai = new ZumbiPai();
        objZumbiFilho = new ZumbiFilho();

        objZumbiFilho.nome = "Zumbi Jr.";
        objZumbiFilho.vida = 100;
        objZumbiFilho.dano = 350;

        print(objZumbiFilho.nome);
        print(objZumbiFilho.vida);
        print(objZumbiFilho.dano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class ZumbiPai
{
    public string nome;
    public int dano;
    public int vida;
}

class ZumbiFilho : ZumbiPai
{
    
}