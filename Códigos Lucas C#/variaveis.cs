using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{

    int moedas = 10; // Variável para a colete de moedas.
    float moedasCarteira = 20.5f; // Variável para contabilizar todas as moedas coletadas pelo jogador.
    bool duvida = false; // Variavel para resposta de Verdadeiro ou Falso.             
    string texto = "Texto interessante."; // Texto a ser exibido.

    bool testeConversao = true; // Verdadeiro = 1 ; Falso = 0.
    int valorConversao;

    // Start is called before the first frame update
    void Start()
    {
        print(moedas);
        print(moedasCarteira);
        print(duvida);
        print(texto);

        valorConversao = Convert.ToInt32(testeConversao);
        print(valorConversao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
