using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifElse : MonoBehaviour
{

    int totalCarteira = 170;
    int precoVida = 150;
    // Start is called before the first frame update
    void Start()
    {
        
        if (totalCarteira > precoVida)
        {
            print("Você consegue comprar uma vida.");
        }
        else if (totalCarteira == precoVida)
        {
            print("Você consegue comprar uma vida, mas ficará sem dinheiro.");
        }
        else
        {
            print("Você não consegue comprar uma vida.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
