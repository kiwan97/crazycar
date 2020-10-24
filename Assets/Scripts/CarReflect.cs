using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityStandardAssets.CrossPlatformInput;

public class CarReflect : MonoBehaviour
{
    // Start is called before the first frame update
    private float temptime;
    public int reflecttime = 3;
    Rigidbody rigid;
    void Start()
    {
        temptime = Time.time;
         rigid = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            if(reflecttime>0)
            {
                reflect();
                reflecttime--;
            }
        }
       // Debug.Log("transform.forward = " + this.transform.forward);
       //Debug.Log("rigid. velocity" + rigid.velocity);
       //Debug.Log("rigid.angularvelocity" + rigid.angularVelocity);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col != null && Time.time - temptime > 0.05f)
        {
            temptime = Time.time;
            if (col.tag == "ReflectTrigger")
            {
                reflect();
            }
        }
        if (col != null && col.tag == "Coin")
        {

            Destroy(col.gameObject); //코인먹었을때코인제거
        }
    }
    //Quaternion q = Quaternion.Euler(0, temp.y *= -1.0f, 0);
    //this.rigid.MoveRotation(q);      
    //Debug.Log(col.contacts[0].thisCollider);
    //Debug.Log(this.rigid.velocity);
    //rigid.AddForce(this.transform.forward*1000000f);
    private void OnCollisionEnter(Collision col)
    {
         if(col != null && col.collider.tag == "TrafficCar")
         {
             this.rigid.AddForce(this.transform.forward * 200000);
             col.gameObject.GetComponent<BoxCollider>().isTrigger = true;
             Rigidbody colrigid = col.gameObject.GetComponent<Rigidbody>();
             if (colrigid != null)
             {
                 colrigid.AddForce(this.transform.forward * 2 +new Vector3(0,2,0));
                 colrigid.useGravity = false;
             }
            col.gameObject.GetComponent<TrafficCarMove>().death();
         }
    }
    public void reflect()
    {
        Vector3 temp = this.transform.eulerAngles;
        this.transform.eulerAngles = new Vector3(0, temp.y * -1.0f, 0);
        this.rigid.velocity = new Vector3(rigid.velocity.x * -1.0f, 0.0f, rigid.velocity.z);
    }
} 
