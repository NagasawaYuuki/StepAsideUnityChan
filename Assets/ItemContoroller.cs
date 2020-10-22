using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ItemContoroller : MonoBehaviour
{
    public GameObject mainCamObj;
    // Start is called before the first frame update
    void Start()
    {
        this.mainCamObj = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.mainCamObj.transform.position.z>gameObject.transform.position.z)
        Destroy(gameObject);
    }
}
