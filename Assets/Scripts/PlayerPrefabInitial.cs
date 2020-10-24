using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabInitial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("coins") == false)
        {
            PlayerPrefs.SetInt("coins", 100);
            PlayerPrefs.Save();
        }
        if(PlayerPrefs.HasKey("value") == false)
        {
            PlayerPrefs.SetInt("value", 0);
            PlayerPrefs.Save();
        }

        Debug.Log("coins = " + PlayerPrefs.GetInt("coins"));
        Debug.Log("value = " + PlayerPrefs.GetInt("value"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
