using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class TrafficCarMove : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    [SerializeField] private float speed = 5.0f;
    public bool canMove = true;
    void Start()
    {
        particle = GameObject.Find("TrafficCarDeathEvent");
        if (particle == null) Debug.Log("파티클시스템 불러오기실패");
    }
    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }

    }
    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void death()
    {
        Invoke("trigger",0.5f);
        Destroy(this.gameObject, 0.5f);
    }
    void trigger()
    {
        GameObject newerparticle = Instantiate(particle, this.transform.position, Quaternion.identity);
        Destroy(newerparticle, 0.5f);
    }
    
}
