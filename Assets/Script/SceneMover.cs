using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPressed()
    {
        SceneManager.LoadScene(sceneIndex+1);
        if(sceneIndex == 5)
        {
            SceneManager.LoadScene(0);
            sceneIndex = 0;
        }
    }

}
