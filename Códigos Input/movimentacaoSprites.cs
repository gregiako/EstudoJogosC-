using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoSprites : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // eixos (x,y,Z)
        //transform.Translate(new Vector3(0.1f,0,0));
        //transform.Rotate(new Vector3(0,0,0.9f));
        transform.localScale += new Vector3(0.1f,0.1f,0);
    }
}
