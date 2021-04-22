using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}


