using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextHandle : MonoBehaviour
{
    public Text scoreText;
    public Text finalText;
    public GameObject finalScore;
    public GameObject carvelocityempty;
    public string mainScene;
    string meter;
    float beforePositionZ;
    float nowPositionZ=-100;
    float curTime = 0;
    Vector3 pos;
    bool death = false;
    // Start is called before the first frame update
    void Start()
    {
        curTime = 0;
        finalScore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        meter = ( (int)this.gameObject.transform.position.z ) +16 + "M";
        scoreText.text = meter;
        nowPositionZ = this.gameObject.transform.position.z;
        curTime += Time.deltaTime;
        //if (nowPositionZ == beforePositionZ && curTime > 10)
        if (this.gameObject.GetComponent<Rigidbody>().velocity.magnitude < 1.0f && curTime > 4.0f)
        {   
            pos = this.transform.position;
            death = true;
            //Debug.Log("!!!");
            finalText.text = meter;
            finalScore.SetActive(true);
            Invoke("goToMain", 4);
        }
        if (death == true)
        {
            this.transform.position = pos;
            carvelocityempty.GetComponent<CarVelocityTextScript>().death = true;
        }
        beforePositionZ = nowPositionZ;
    }
    void goToMain()
    {
        Debug.Log("GameOver!");
        if (!string.IsNullOrEmpty(mainScene))
            SceneManager.LoadScene(mainScene);
        else
            Debug.Log("Please write a scene name in the 'newGameSceneName' field of the Main Menu Script and don't forget to " +
                "add that scene in the Build Settings!");
    }
}
