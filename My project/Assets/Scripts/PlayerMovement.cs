using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        }

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed;

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
