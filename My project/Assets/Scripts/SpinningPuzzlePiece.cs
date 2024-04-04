using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPuzzlePiece : MonoBehaviour
{
    // Start is called before the first frame update
    public bool interactingRange = false;
    Collider m_ObjectCollider;
    public Transform block;
    void Start()
    {
        m_ObjectCollider = GetComponent<Collider>();
        m_ObjectCollider.isTrigger = true;
    }
    private void OnTriggerStay(Collider other)
    {
        interactingRange = true;
        Debug.Log("R and L rotate the blocks");

    }
    private void OnTriggerExit(Collider other)
    {
        interactingRange = false;
      // Debug.Log("Exited");
    }
    // Update is called once per frame
    void Update()
    {
        if (interactingRange)
        {
           // Debug.Log("In Range");
            if (Input.GetKey(KeyCode.R))
            {
               // Debug.Log("Right");
                block.transform.Rotate(new Vector3(0, 0.1f, 0));
               // Debug.Log(block.transform.eulerAngles.y - 360.0f);
            }
            if (Input.GetKey(KeyCode.L))
            {
              //  Debug.Log("Left");
                block.transform.Rotate(new Vector3(0, -0.1f, 0));
                //Debug.Log(block.transform.rotation);
            }
        }
    }
}
