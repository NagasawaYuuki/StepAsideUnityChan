using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 3, 0);
    }
}
