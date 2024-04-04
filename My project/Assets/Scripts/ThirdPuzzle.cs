using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SwordDoor;
    public Transform PickaxeDoor;

    public Transform SB1;
    public Transform SB2;
    public Transform SB3;

    private bool SDOpen = false;
    private bool PDOpen = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool SB1Sword = false;
        bool SB1Pick = false;

        bool SB2Sword = false;
        bool SB2Pick = false;

        bool SB3Sword = false;
        bool SB3Pick = false;
        Debug.Log(SB1.transform.eulerAngles.y + " " + SB2.transform.eulerAngles.y + " " + SB3.transform.eulerAngles.y);
        if (SB1.transform.eulerAngles.y > 345 || SB1.transform.eulerAngles.y < 15)
        {
            SB1Sword = true;
        }
        if (SB1.transform.eulerAngles.y > 165 && SB1.transform.eulerAngles.y < 195)
        {
            SB1Pick = true;
        }

        if (SB2.transform.eulerAngles.y > 345 || SB2.transform.eulerAngles.y < 15)
        {
            SB2Sword = true;
        }
        if (SB2.transform.eulerAngles.y > 165 && SB2.transform.eulerAngles.y < 195)
        {
            SB2Pick = true;
        }

        if (SB3.transform.eulerAngles.y > 345 || SB3.transform.eulerAngles.y < 15)
        {
            SB3Sword = true;
        }
        if (SB3.transform.eulerAngles.y > 165 && SB3.transform.eulerAngles.y < 195)
        {
            SB3Pick = true;
        }

        if (SB1Sword && SB2Sword && SB3Sword && !SDOpen)
        {
            SDOpen = true;
            SwordDoor.transform.position += new Vector3(0, 10, 0);
        } else if (SDOpen && (!SB1Sword || !SB2Sword || !SB3Sword))
        {
            SDOpen = false;
            SwordDoor.transform.position += new Vector3(0, -10, 0);
        }
        if (SB1Pick && SB2Pick && SB3Pick && !PDOpen)
        {
            PDOpen = true;
            PickaxeDoor.transform.position += new Vector3(0, 10, 0);
        } else if (PDOpen && (!SB1Pick || !SB2Pick || !SB3Pick))
        {
            PDOpen = false;
            PickaxeDoor.transform.position += new Vector3(0, -10, 0);
        }
    }
}
