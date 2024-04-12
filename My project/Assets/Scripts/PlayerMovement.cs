using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    [SerializeField] private AudioClip jumpSound;
    //[SerializeField] private AudioClip walkingSound;

    private AudioSource audioSource1; 
    private AudioSource audioSource2; 

    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        audioSource1 = GetComponent<AudioSource>(); 
        audioSource2 = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Jump");
            rb.AddForce(new Vector3(0, 20.0f, 0), ForceMode.Impulse);
            isGrounded = false;
            audioSource1.clip = jumpSound;
            audioSource1.Play();
        }

        float currMoveSpeed;

        if(Input.GetKey(KeyCode.LeftControl))
        {
            currMoveSpeed = moveSpeed * 0.5f;
        }
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            currMoveSpeed = moveSpeed * 2.0f;
        }
        else
        {
            currMoveSpeed = moveSpeed;
        }

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * currMoveSpeed;

       
                

        Vector3 cameraForward = Camera.main.transform.forward;

        Quaternion playerOrientation = Quaternion.LookRotation(cameraForward);

        movement = playerOrientation * movement;

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);

        rb.MoveRotation(playerOrientation);

    }
}
