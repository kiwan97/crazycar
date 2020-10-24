using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCarSpawn : MonoBehaviour
{
    public GameObject trafficCar;
    public GameObject[] traffic = new GameObject[4];

    //public float x_position;
    //public float y_position;
    //public float z_position;
    public float x_rotate = 0.0f;
    public float y_rotate = 0.0f;
    public float z_rotate = 0.0f;
    
    // Start is calle
    IEnumerator trafficCarSpawn()
    {
        while (true)
        {
            int temp = (int)Random.Range(0, 3);
            Instantiate(traffic[temp], this.transform.position, Quaternion.Euler(x_rotate,y_rotate,z_rotate)); //스폰대상 , 위치 , 각도
            yield return new WaitForSeconds(Random.Range(3.0f,7.0f)); //3~7초 랜덤사이에 생성
        }
    }
    void Start()
    {
        Invoke("routine",Random.Range(2.0f,7.0f));
    }
    void routine()
    {
        StartCoroutine(trafficCarSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
