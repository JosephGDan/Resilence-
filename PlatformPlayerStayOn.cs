using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayerStayOn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Player")
        {
            collision.gameObject.transform.parent = this.gameObject.transform;
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.transform.parent = null;
    }
}
