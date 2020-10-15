using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchAula : MonoBehaviour
{

    /*
    Estado 1 = Corajoso
    Estado 2 = Meio termo
    Estado 3 = Covarde
    */

    int estadoInimigo = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (estadoInimigo) 
        {
            case 1:
                print("Atacar o herói.");
                break;
            case 2:
                print("Atacar quando for oportuno.");
                break;
            case 3:
                print("Fugir da luta.");
                break;
            default:
                print("Nenhum estado selecionado.");
                break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
