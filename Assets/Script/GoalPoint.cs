using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPoint : MonoBehaviour
{

    //float timeManage;
    public GameObject nextButton;
    public static bool win;

    // Start is called before the first frame update
    void Start()
    {
        //timeManage = 0;
        win = false;
        nextButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "PlayerObject")
        {
     
                nextButton.SetActive(true);
                gameObject.SetActive(false);
                win = true;


        }
        
    }

}
