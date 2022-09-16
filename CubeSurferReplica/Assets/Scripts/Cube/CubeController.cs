using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private HeroStackController _heroStackController;
    private Vector3 direction = Vector3.back;
    private RaycastHit hit;
    private bool isStack = false;

    private void Awake()
    {
        _heroStackController = FindObjectOfType<HeroStackController>();
    }

    private void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()//Raycast ile küpleri toplayacağımız fonksiyon
    {
        if (Physics.Raycast(transform.position,direction,out hit,1f))
        {
            if (!isStack)
            {
                isStack = true;
                _heroStackController.IncreaseBlockStack(gameObject);
            }

            if (hit.transform.name == "ObstacleCube")//Çarptığımız nesnenin adı "ObstacelCube" ise;
            {
                _heroStackController.DecreaseBlockStack(gameObject);//heroStackController içindeki DecreaseBlockStack'i çalıştır.
            }   
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
        
    }
}
