using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinRotation : MonoBehaviour
{
    private float rotateSpeed = 5;

    void FixedUpdate()
    {
        transform.Rotate(rotateSpeed, 0, 0);
    }
}
