using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public StatHealth health;
    public StatSanity sanity;
	void Start () {
		
	}

    public void Awake()
    {
        health.Initialize();
        sanity.InitializeSanity();

    }

    
    void Update ()
    {
        //for testing purposes...cheat codes.
        if (Input.GetKeyDown(KeyCode.K))
        {
            health.CurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            health.CurrentValue += 10;
        }

        //testing for sanity...cheat codes
        if (Input.GetKeyDown(KeyCode.O))
        {
            sanity.CurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            sanity.CurrentValue += 10;
        }
    }
}
