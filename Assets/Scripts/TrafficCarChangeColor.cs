using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCarChangeColor : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Random.ColorHSV());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
