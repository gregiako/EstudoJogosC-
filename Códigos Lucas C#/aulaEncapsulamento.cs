using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaEncapsulamento : MonoBehaviour
{
    Encapsulamento objTeste;

    // Start is called before the first frame update
    void Start()
    {
        objTeste = new Encapsulamento();

        print(objTeste.Idade); // Utilizar sempre a propriedade que acessou o atributo
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Encapsulamento
{
    private int idade = 10;

    public int Idade { // A propriedade tem que ter o mesmo nome que o atributo, mas com letra maiúscula
        get {return idade;} // Pegar um atributo
        set {idade = value;} // Define um valor ao atributo
    }
}