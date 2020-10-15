using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadoresLogicos : MonoBehaviour
{

    /*
    == Igual
    != Diferente
    > Maior que
    < Menor que
    >= Maior ou igual a
    <= Menor ou igual a    
     */

     int num1 = 10;
     int num2 = 20;

    // Start is called before the first frame update
    void Start()
    {

        // && = E/AND

            //num1 == num2 = FALSE/FALSO
            //num1 != num2 = TRUE/VERDADEIRO

            print(num1 != num2 && num1 != num2);//dois valores TRUE = TRUE
            print(num1 != num2 && num1 == num2);//um valor TRUE e um valor FALSE = FALSE
            print(num1 == num2 && num1 != num2);//um valor FALSE e um valor TRUE = FALSE
            print(num1 == num2 && num1 == num2);//dois valores FALSE = FALSE

        // || = OU/OR

            //num1 == num2 = FALSE/FALSO
            //num1 != num2 = TRUE/VERDADEIRO

            print(num1 != num2 || num1 != num2);//dois valores TRUE = TRUE
            print(num1 != num2 || num1 == num2);//um valor TRUE e um valor FALSE = TRUE
            print(num1 == num2 || num1 != num2);//um valor FALSE e um valor TRUE = TRUE
            print(num1 == num2 || num1 == num2);//dois valores FALSE = FALSE

        // ! = NOT/NÃO

            //num1 == num2 = FALSE/FALSO
            //num1 != num2 = TRUE/VERDADEIRO

            print(!(num1 != num2));//se é TRUE, vira FALSE
            print(!(num1 == num2));//se é FALSE, vira TRUE

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
