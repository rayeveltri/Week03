using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        //empty
    }
    public float speed = 5f;


    void Update()
    {
        movChar();
        jumpFeat();
    }
    void movChar()//this moves player//
    { 
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v);
            transform.Translate(move * speed * Time.deltaTime);
    }
    void jumpFeat()//this makes the player jump//
    {
        float j = Input.GetAxis("Jump");
        Vector3 jump = new Vector3(0, j, 0);
            transform.Translate(jump * speed * Time.deltaTime);

    }
}
