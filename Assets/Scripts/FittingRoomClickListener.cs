using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FittingRoomClickListener : MonoBehaviour
{
    public string nameOfMainScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("Clicked!");
        if (!string.IsNullOrEmpty(nameOfMainScene))
            SceneManager.LoadScene(nameOfMainScene);
        else
            Debug.Log("Please write a scene name in the 'newGameSceneName' field of the Main Menu Script and don't forget to " +
                "add that scene in the Build Settings!");
    }
}
