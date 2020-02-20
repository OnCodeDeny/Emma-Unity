﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornGenerator : MonoBehaviour
{
    public GameObject acornPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateAcorn(Vector3 position, int number)
    {
        for (int i = 0; i < number; i++)
        {
            Vector3 offset = new Vector3(Random.Range(-1, 2), Random.Range(-1, 2));
            GameObject acorn = Instantiate(acornPrefab, position + offset, Quaternion.identity);
            acorn.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-0.8f, 0.8f), Random.Range(-0.8f, 0.8f)), ForceMode2D.Impulse);
        }
    }
}