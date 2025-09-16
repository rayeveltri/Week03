using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< Updated upstream
        public float moveSpeed = 5f;
        void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 move = new Vector3(-h, 0f, -v);
            transform.Translate(move * moveSpeed * Time.deltaTime, Space.Self);
        }
    
=======
    public float moveSpeed = 5f;

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
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.Self);
    }
>>>>>>> Stashed changes
}


