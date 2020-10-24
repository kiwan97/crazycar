using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CoinHandle : MonoBehaviour
{
    public Text coinText;
    public HandleTextFile HTF = new HandleTextFile();


    // Start is called before the first frame update
    private int coins;
    void Start()
    {
        HTF.ReadString();

        //coins = int.Parse(HTF.getText());
        //coins = StaticCarValue.coins;
        if (!PlayerPrefs.HasKey("coins")) { PlayerPrefs.SetInt("coins", 100); PlayerPrefs.Save(); }
        coins = PlayerPrefs.GetInt("coins");
        Debug.Log("coin = " + coins);
        Debug.Log("!!!!!!");
        coinText.text = "coin : " + coins.ToString();
        //Debug.Log(HTF.getText() + "!!!!!");
        //Debug.Log("start _ carReflect!!");
    }

    // Update is called once per frame
    void Update()
    {
        coins = PlayerPrefs.GetInt("coins");
        coinText.text = "coin : " + coins.ToString();
        PlayerPrefs.SetInt("coins",coins);
        PlayerPrefs.Save();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col != null)
        {
            if (col.tag == "Coin")
            {
                coins++;
                //StaticCarValue.coins = coins;
               PlayerPrefs.SetInt("coins", coins);
               PlayerPrefs.Save();
                //Debug.Log("코인제거됨, coin = " + coins);
                coinText.text = "coin :" + coins.ToString();
                HTF.WriteString(coins.ToString());

                Destroy(col.gameObject); //코인먹었을때코인제거
            }
        }
    }
}
