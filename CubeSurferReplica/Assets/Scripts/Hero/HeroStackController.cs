using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    private GameObject lastBlockObject;

    private void Start()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseBlockStack(GameObject _gameObject)//Karşılaştığımız küpleri son pozisyona göre bu methodla toplayacağız
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x,lastBlockObject.transform.position.y -2f, lastBlockObject.transform.position.z);//Yeni aldığımız Cube'u pozisyonu belirleyerek MainCube verdik.
        _gameObject.transform.SetParent(transform);//Çarptığımız gameObject'in Parent'ı bu class'ın bağlı olduğu transform olsun.
        blockList.Add(_gameObject);//listeye ekliyoruz
        UpdateLastBlockObject();
    }

    private void UpdateLastBlockObject()
    {
        lastBlockObject = blockList[blockList.Count - 1];//Burada son cube'u almış oluyoruz
    }
}


