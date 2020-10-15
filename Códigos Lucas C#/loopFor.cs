using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopFor : MonoBehaviour
{
    int cont;
    int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (cont = 0; cont < 10; cont++)
        {
            print("Contador no número: " + cont);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
