using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaInputs : MonoBehaviour
{
    private float velocidade = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Input.GetKeyUp só vai ler o resultado após soltar a tecla desejada
            // Input.GetKeyDown vai ler quando apertar a tecla desejada (só lê uma vez mesmo a tecla pressionada)
            // Input.GetKey lê continuamente se a tecla estiver pressionada
            transform.Translate(new Vector3(velocidade * Time.deltaTime,0,0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Input.GetKeyUp só vai ler o resultado após soltar a tecla desejada
            // Input.GetKeyDown vai ler quando apertar a tecla desejada (só lê uma vez mesmo a tecla pressionada)
            // Input.GetKey lê continuamente se a tecla estiver pressionada
            transform.Translate(new Vector3(-velocidade * Time.deltaTime,0,0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Input.GetKeyUp só vai ler o resultado após soltar a tecla desejada
            // Input.GetKeyDown vai ler quando apertar a tecla desejada (só lê uma vez mesmo a tecla pressionada)
            // Input.GetKey lê continuamente se a tecla estiver pressionada
            transform.Translate(new Vector3(0,velocidade * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Input.GetKeyUp só vai ler o resultado após soltar a tecla desejada
            // Input.GetKeyDown vai ler quando apertar a tecla desejada (só lê uma vez mesmo a tecla pressionada)
            // Input.GetKey lê continuamente se a tecla estiver pressionada
            transform.Translate(new Vector3(0,-velocidade * Time.deltaTime,0));
        }
    }
}
