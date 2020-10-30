/*
Usando polimorfismo crie um método chamado andar, dentro da
classe zumbi_filho e zumbi, garanta que seremos capazes de
sobrescrever esse método.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercicio10 : MonoBehaviour
{
    Zumbi_Pai zumbi_pai;
    Zumbi_Filho zumbi_filho;

    // Start is called before the first frame update
    void Start()
    {
        zumbi_pai = new Zumbi_Pai();
        zumbi_filho = new Zumbi_Filho();

        zumbi_filho.andar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Zumbi_Pai : MonoBehaviour
{
    public virtual void andar() {
        print("O Zumbi Pai está andando.");
    }
}

class Zumbi_Filho : Zumbi_Pai
{
    public override void andar()
    {
        print("O Zumbi Filho está andando.");
    }
}