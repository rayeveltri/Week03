using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CanvasActivator : MonoBehaviour
{
    // Drag your disabled Canvas GameObject here in the Inspector
    [SerializeField]
    private GameObject myCanvas;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with the player (using a tag)
        if (collision.gameObject.CompareTag("Player"))
        {
            myCanvas.SetActive(true);
        }
    }
}