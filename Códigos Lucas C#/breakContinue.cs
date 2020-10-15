using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakContinue : MonoBehaviour
{
    // break = abandona o laço quando alcança uma condição
    // continue = continua o laço, mas pula um resultado em uma condição
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                continue; // break; ou continue;                
            }
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
