using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float minX, maxX;


    private void Start()
    {
        Destroy(gameObject, 4f);
    }
}

