using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopDoWhile : MonoBehaviour
{
    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            print(cont);
            cont++;
        } while (cont <= 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
