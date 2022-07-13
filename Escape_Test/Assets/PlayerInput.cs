using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float playerX { get; set; }
    public float playerY { get; set; }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerY = Input.GetAxisRaw("Vertical");
        playerX = Input.GetAxisRaw("Horizontal");
    }
}
