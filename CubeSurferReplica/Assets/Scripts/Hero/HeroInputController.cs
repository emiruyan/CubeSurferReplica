using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }//horizontalValue'ye bu şekilde eriştik.
    }

    private void Update()
    {
        HandleHeroHorizontalInput();
    }

    private void HandleHeroHorizontalInput()
    {
        if (Input.GetMouseButton(0))//Mouse sol click basılı ise;
        {
            horizontalValue = Input.GetAxis("Mouse X");//Unity içerisindeki GtAxs'i horizontalValue'ye atadık.
        }
        else//Mouse sol click basılı değil ise;
        {
            horizontalValue = 0;
        }
    }
}
