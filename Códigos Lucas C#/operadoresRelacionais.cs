using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadoresRelacionais : MonoBehaviour
{

    /*
    
    == Igual
    != Diferente
    > Maior que
    < Menor que
    >= Maior ou igual a
    <= Menor ou igual a    
    
    */

    int numero1 = 10;
    int numero2 = 20;

    // Start is called before the first frame update
    void Start()
    {
        print(numero1 == numero2); // False
        print(numero1 != numero2); // True
        print(numero1 > numero2); // False
        print(numero1 < numero2); // True
        print(numero1 >= numero2); // False
        print(numero1 <= numero2); // True
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
