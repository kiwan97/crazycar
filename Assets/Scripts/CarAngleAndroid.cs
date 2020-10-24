using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAngleAndroid : MonoBehaviour
{
    public GameObject mcar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x > (Screen.width / 2))
            {
                Vector3 temp = mcar.transform.eulerAngles;
                mcar.transform.eulerAngles = new Vector3(0, temp.y +2f, 0);
            }
            if (touch.position.x < (Screen.width / 2))
            {
                Vector3 temp = mcar.transform.eulerAngles;
                mcar.transform.eulerAngles = new Vector3(0, temp.y -2f, 0);
            }
        }
    }
}
