using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    [Header("Floats")]
    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
