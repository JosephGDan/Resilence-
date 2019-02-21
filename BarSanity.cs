using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarSanity : MonoBehaviour {

    public float fillAmount;
    public Image content;

    public BarHealth health;

    private bool damaged;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    public float flashSpeed = 5f;
    public Image damagedImage;

    public float lerpSpeed;

    public Text sanityCount;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

    void Start()
    {
        
    }

    


    void Update()
    {
        damaged = false;
        HandleSanityBar();
        LoseSanity();
         if(fillAmount < 0 )
        {
            health.fillAmount -= (.05f * Time.deltaTime);
            health.HandleHeathBar();
            damaged = true;
            
        }
        if (damaged)
        {
            damagedImage.color = flashColor;
        }
        else
        {
            damagedImage.color = Color.Lerp(damagedImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        Debug.Log(fillAmount);

    }

    public void HandleSanityBar()
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

    public void LoseSanity()
    {
        
        fillAmount -= (.05f * Time.deltaTime);
    }

    

    


}
