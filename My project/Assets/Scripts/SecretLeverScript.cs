using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretLeverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isTriggered = false;
    Collider m_ObjectCollider;
    public Transform wall;
    void Start()
    {
        m_ObjectCollider = GetComponent<Collider>();
        //m_ObjectCollider.isTrigger = true;

        wall = this.transform.Find("SecretWall");
        if (wall == null)
        {
            Debug.Log("Couldn't find wall");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        m_ObjectCollider.isTrigger = true;
        Debug.Log("Triggered");
        if (m_ObjectCollider.isTrigger)
        {
            wall.transform.position += new Vector3(0.0f, -10.0f, 0.0f);
            //wall.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
