/*
Crie um objeto da classe zumbi e exiba no console cada atributo
criado.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio8 : MonoBehaviour
{
    ZumbiMaligno objZumbi;

    // Start is called before the first frame update
    void Start()
    {
        objZumbi = new ZumbiMaligno();

        print(objZumbi.nomeMonstro);
        print(objZumbi.vidaMonstro);
        print(objZumbi.danoMonstro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class ZumbiMaligno
{
    public string nomeMonstro = "Zumbi Maligno";
    public int vidaMonstro = 200;
    public int danoMonstro = 500;
}