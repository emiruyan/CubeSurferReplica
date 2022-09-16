using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;//Cameranın takip edeceği Transform
    private Vector3 offset;//Camera ve hero arasındaki mesafeyi tutacak olan değişken
    private Vector3 newPosition;
    [SerializeField] private float lerpValue;

    private void Start()
    {
        offset = transform.position - heroTransform.position;
    }

    private void LateUpdate()//Camera takip'te LateUpdate daha sağlıklı
    {
        SetCameraSmoothFollow();
    }
 
    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position,
            new Vector3(0f, heroTransform.position.y, heroTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
