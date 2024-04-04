using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureVault : MonoBehaviour
{
    // Start is called before the first frame update
    public bool typingRange = false;
    Collider m_ObjectCollider;
    public Transform door;
    private string m_Code;
    void Start()
    {
        m_ObjectCollider = GetComponent<Collider>();
        m_ObjectCollider.isTrigger = true;

       // door = this.transform.Find("TreasureRoomDoor");
        if (door == null)
        {
            Debug.Log("Couldn't find door");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        typingRange = true;
        Debug.Log("Triggered");
        
    }
    private void OnTriggerExit(Collider other)
    {
        typingRange = false;
        Debug.Log(m_Code);
        m_Code = null;
    }
    // Update is called once per frame
    void Update()
    {
        if (typingRange)
        {
            if (Input.GetKeyUp(KeyCode.Alpha0))
            {
                m_Code += 0;
            }
            if (Input.GetKeyUp(KeyCode.Alpha1)) {
                m_Code += 1;
            }
            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                m_Code += 2;
            }
            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                m_Code += 3;
            }
            if (Input.GetKeyUp(KeyCode.Alpha4))
            {
                m_Code += 4;
            }
            if (Input.GetKeyUp(KeyCode.Alpha5))
            {
                m_Code += 5;
            }
            if (Input.GetKeyUp(KeyCode.Alpha6))
            {
                m_Code += 6;
            }
            if (Input.GetKeyUp(KeyCode.Alpha7))
            {
                m_Code += 7;
            }
            if (Input.GetKeyUp(KeyCode.Alpha8))
            {
                m_Code += 8;
            }
            if (Input.GetKeyUp(KeyCode.Alpha9))
            {
                m_Code += 9;
            }
        }
        if (m_Code == "37465")
        {
            if (door != null)
            {
                door.transform.position += new Vector3(0, 5.0f, 0);
            } else
            {
                Debug.Log("Door is null");
            }
        }
    }
}
