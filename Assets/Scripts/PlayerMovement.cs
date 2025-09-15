using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting code");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
       
        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.down;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.left;
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
