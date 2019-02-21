using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockDoor : MonoBehaviour {

    public Image message;

    public bool playerPresent = false;

    public string KeyNeeded = "none";

	void Start ()
    {
        message.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerPresent)
        {
            if (KeyNeeded == "none")
            {
                DoorUnlocked();
            }
            else
            {
                DoorLocked();
            }

        }
	}

    public void DoorLocked()
    {
        GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");
        Inventory inv = thePlayer.GetComponent<Inventory>();
        if (inv.HasKey(KeyNeeded))
        {
            DoorUnlocked();
        }
        else
        {
            print("You need the " + KeyNeeded + "key");
        }
    }

    public void DoorUnlocked()
    {
        Destroy(this.gameObject);
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.gameObject.SetActive(true);
            playerPresent = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.gameObject.SetActive(false);
            playerPresent = false;
        }
    }
}
