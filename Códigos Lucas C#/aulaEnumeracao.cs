using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaEnumeracao : MonoBehaviour
{
    enum AI {Atacar,Patrulhar,Correr}

    // Start is called before the first frame update
    void Start()
    {
        AI vilaoFase1 = AI.Patrulhar;
        AI vilaoFase2 = AI.Atacar;
        AI vilaoFase3 = AI.Correr;

        print(vilaoFase1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
