using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroInputController _heroInputController; //heroInputController class'ımızı çağırdık
    [SerializeField] private float forwardMovementSpeed;//Hero'nun öne doğru hareketi için hız değişkeni
    [SerializeField] private float horizontalMovementSpeed;//Hero'nun yatay hareketi içn hız değişkeni
    [SerializeField] private float horizontalLimitValue;//Movement Clamp işlemi için limit değişkeni

    private float newPositionX;//X değerimiz için değişken


    private void FixedUpdate()//Bir fizik işlemi olacağı için FixedUpdate kullandık. Bu method'ta daha sağlıklı.
    {
        SetHeroForwardMovement();
        SetHeroHorizontalMovement();
    }

    private void SetHeroForwardMovement()//Heronun öne doğru hareketi
    {
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetHeroHorizontalMovement()//Heronun yatay hareketi
    {
        newPositionX = transform.position.x + _heroInputController.HorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);//Movement Clamp
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}


