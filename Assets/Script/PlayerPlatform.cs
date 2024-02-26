using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 curposition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        curposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 value = Vector3.up * 100;
            rb.AddForceAtPosition(value, curposition, ForceMode2D.Force);
        
        }
    }
}
