using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaConstrutores : MonoBehaviour
{

    Construtor objeto;
    // Start is called before the first frame update
    void Start()
    {
        objeto = new Construtor();

        print(objeto.valor1);
        print(objeto.valor2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Construtor
{
    // As variaveis precisam ser declaradas na classe
    public int valor1;
    public string valor2;

    public Construtor(){ // O construtor precisa ter o mesmo nome que a classe
        valor1 = 10;
        valor2 = "Hello World.";
    } 
}
