using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public List<string> keys;

    // Use this for initialization
    void Start()
    {
        if (keys == null) keys = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddKey(string newKey)
    {
        keys.Add(newKey);
    }

    public bool HasKey(string keyName)
    {
        return keys.Contains(keyName);
    }
}
