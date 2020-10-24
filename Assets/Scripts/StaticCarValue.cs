using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCarValue : MonoBehaviour
{
    static public int value = 0;
    static public float ItemLevel = 0f;
    static public int coins = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
