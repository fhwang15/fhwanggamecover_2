using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 value = Vector3.up * 120;
            rb.AddForceAtPosition(value, new Vector2(0.24f, 1.85f), ForceMode2D.Force);
            Debug.Log("Work");
        
        }
    }
}
