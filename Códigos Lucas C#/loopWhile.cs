using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopWhile : MonoBehaviour
{
    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (cont <= 10)
        {
            print(cont);
            cont++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
