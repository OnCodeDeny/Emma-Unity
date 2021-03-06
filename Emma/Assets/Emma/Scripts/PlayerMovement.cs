﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Make slot to drag PlayerController script into
    public PlayerController controller;

    private Animator anim;

    public float runSpeed = 40f;
    float horizontalMovement = 0f;
    bool jump = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Get player input.
        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Space to jump.
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        // Move character.
        controller.Move(horizontalMovement * Time.fixedDeltaTime, jump);
        // So you don't keep jumping forever:      
        jump = false;

        if (horizontalMovement!= 0)
        {
            anim.SetBool("IsMoving", true);
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }
    }
}
