using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : MonoBehaviour
{
    [SerializeField] float speed = 100f;

    public static Cube Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float xRotateSpeed = 1 * speed * Time.deltaTime;
        transform.Rotate(xRotateSpeed, 0, 0);
    }
}
