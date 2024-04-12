using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{

    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            playerAnimator.SetBool("isMoving", true);
        }
        else
        {
            playerAnimator.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            playerAnimator.SetBool("isSneaking", true);
        }
        else
        {
            playerAnimator.SetBool("isSneaking", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("isRunning", true);
        }
        else
        {
            playerAnimator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.E))
        {
            playerAnimator.SetBool("isReaching", true);
        }
        else 
        {
            playerAnimator.SetBool("isReaching", false);
        }


    }
}
