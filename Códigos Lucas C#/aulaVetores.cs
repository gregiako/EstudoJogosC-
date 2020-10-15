using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaVetores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*int[] array = new int[4];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;

        print(array[1]);*/

        int[] array = new int[10];

        for (int i = 0; i <= 9; i++)
        {
            array[i] = i + 1;

            print(i + ":" + array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
