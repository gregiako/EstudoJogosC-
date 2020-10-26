using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classeObjeto : MonoBehaviour
{
    Felino gatoFase1;
    Felino gatoFase2;

    // Start is called before the first frame update
    void Start()
    {
        gatoFase1 = new Felino();
        gatoFase2 = new Felino();

        gatoFase1.nome = "MeuMeow";
        gatoFase1.corPelo = "Listrado";

        gatoFase2.nome = "Gato Louco";
        gatoFase2.corPelo = "Caramelo";

        print(gatoFase1.nome + " é da cor: " + gatoFase1.corPelo);

        print(gatoFase2.nome + " é da cor: " + gatoFase2.corPelo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// Classe Pai
class Felino {
    // Características
    public string nome;
    public string corPelo;
    public int forca;
}

// Classe Filha
class GatoLouco : Felino
{
    public void acessar() {
        // nome = "GatoLouco";
    }
}