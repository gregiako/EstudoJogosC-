using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaPolimorfismo : MonoBehaviour
{
    Leao objLeao;
    Gato objGato;

    // Start is called before the first frame update
    void Start()
    {
        objLeao = new Leao();
        objGato = new Gato();

        objLeao.comer();
        objGato.comer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Animal : MonoBehaviour
{
    public virtual void comer() { 
        // Método para uma ação da classe Animal
        print("O animal está comendo.");
    }
}

class Leao : Animal
{
    public override void comer() {
        print("O Leão está comendo.");
    }
}

class Gato : Animal
{
    public override void comer() {
        print("O Gato está comendo.");
    }
}