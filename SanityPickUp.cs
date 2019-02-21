using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityPickUp : MonoBehaviour {

    public BarSanity sanity;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        
        
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        sanity.fillAmount += .2f;
        
    }
}
