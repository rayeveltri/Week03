using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWin : MonoBehaviour
{
    public Transform winPoint;
    public float winDistance = 2f;
    public Transform player;
    public GameObject pickupEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distWin = Vector3.Distance(player.position, winPoint.position);
        if (distWin <= winDistance)
        {
            WinGame();
        }
    }
    void WinGame()
    {
        Destroy(pickupEffect);
        Debug.Log("Picked up" + pickupEffect.name);
    }
}
