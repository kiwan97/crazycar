using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FittingRoomCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public Text coinText;
    public HandleTextFile HTF2 = new HandleTextFile();

    // Start is called before the first frame update
    private int coins;
    void Start()
    {
        HTF2.ReadString();
        //coins = int.Parse(HTF2.getText());
        if (!PlayerPrefs.HasKey("coins")) { PlayerPrefs.SetInt("coins", 100); PlayerPrefs.Save(); }
        coins = PlayerPrefs.GetInt("coins");
        coinText.text = "coin : " + coins.ToString();
        //Debug.Log(HTF2.getText() + "!!!!!");
        //Debug.Log("start _ carReflect!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
