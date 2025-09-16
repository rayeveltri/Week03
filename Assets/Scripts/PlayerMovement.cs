using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        public float moveSpeed = 5f;
        void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 move = new Vector3(-h, 0f, -v);
            transform.Translate(move * moveSpeed * Time.deltaTime, Space.Self);
        }
    
}
