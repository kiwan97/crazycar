using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FittingPandoraClick : MonoBehaviour
{
    public GameObject ItemAdjectedText;
    public Text coinText;
    public Text LevelText;
    public HandleTextFile HTF2 = new HandleTextFile();
    private int coins;
    private int accel2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        ItemAdjectedText.SetActive(false);
        HTF2.ReadString();
        //coins = int.Parse(HTF2.getText());
        //coins = StaticCarValue.coins;
        if (!PlayerPrefs.HasKey("coins")) { PlayerPrefs.SetInt("coins", 100); PlayerPrefs.Save(); }

        coins = PlayerPrefs.GetInt("coins");
        coinText.text = "coin : " + coins.ToString();
        Debug.Log("FittingRoomPandora.cs working");
        //Debug.Log(HTF2.getText() + "!!!!!");
        //Debug.Log("start _ carReflect!!");
    }

    // Update is called once per frame
    void Update()
    {
        coins = PlayerPrefs.GetInt("coins");
        coinText.text = "coin : " + coins.ToString();
        PlayerPrefs.SetInt("coins", coins);

        //if (!PlayerPrefs.HasKey("accel")) PlayerPrefs.SetInt("accel", 0);
        LevelText.text = "업그레이드: " + PlayerPrefs.GetInt("value");
        PlayerPrefs.SetInt("value", PlayerPrefs.GetInt("value"));
        PlayerPrefs.Save();
        //LevelText.text = "업그레이드: " + PlayerPrefs.GetInt("accel").ToString();
    }
    private void OnMouseDown()
    {
        if (coins < 10) return;
        Invoke("toggle", 2.0f);
        ItemAdjectedText.SetActive(true);
        StaticCarValue.value += 1;
        accel2++;
        PlayerPrefs.SetInt("value", PlayerPrefs.GetInt("value") + 1);
        //PlayerPrefs.SetInt("accel", PlayerPrefs.GetInt("accel") + 1);
        coins -= 10;
        PlayerPrefs.SetInt("coins",coins);
        PlayerPrefs.Save();
        //StaticCarValue.coins = coins;
        HTF2.WriteString(coins.ToString());
        coinText.text = "coin : " + coins.ToString();
        //Debug.Log("value changed!");
        //Debug.Log("StaticCarValue = " + StaticCarValue.value);
    }
    void toggle()
    {
        ItemAdjectedText.SetActive(false);
    }

}
