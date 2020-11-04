using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aulaInputMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseHorizontal = Input.GetAxis("Mouse X");
        float mouseVertical = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3(mouseHorizontal * Time.deltaTime,mouseVertical * Time.deltaTime,0));
    }
}
