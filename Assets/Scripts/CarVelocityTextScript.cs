using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarVelocityTextScript : MonoBehaviour
{
    public GameObject mCar;
    public Text CarVelocityText;
    public bool death = false;
    public int temp2;
    // Start is called before the first frame update
    void Start()
    {
        CarVelocityText.text = "0 Km/h";
    }

    // Update is called once per frame
    void Update()
    {
        if (death == false)
        {
            float temp = mCar.GetComponent<Rigidbody>().velocity.magnitude;
            temp = temp * 3.6f;   //km/h로 변환
            temp2 = (int)temp;
            CarVelocityText.text = temp2.ToString() + " Km/h";
        }
        else
        {
            temp2 = 0;
            CarVelocityText.text = temp2.ToString() + " Km/h";
        }
    }
}
