using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeReset : MonoBehaviour
{
    public Button resetBtn;
    public Button coinUP;
    // Start is called before the first frame update
    void Start()
    {
        resetBtn.onClick.AddListener(reset2);
        coinUP.onClick.AddListener(coinUP1);
    }
    void reset2()
    {
        PlayerPrefs.SetInt("value", 0);
        PlayerPrefs.Save();
    }
    void coinUP1()
    {
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 10);
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
