using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarHealth : MonoBehaviour {

    public float fillAmount;
    public Image content;

    public float lerpSpeed;
    public Text healthCount;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        HandleHeathBar();
	}

    public void HandleHeathBar()
    {
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
