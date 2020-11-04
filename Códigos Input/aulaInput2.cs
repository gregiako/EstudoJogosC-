using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaInput2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal * Time.deltaTime,vertical * Time.deltaTime,0));
    }
}
