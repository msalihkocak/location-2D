using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.forward = Vector3.back;
        GameObject.Find("Test");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
