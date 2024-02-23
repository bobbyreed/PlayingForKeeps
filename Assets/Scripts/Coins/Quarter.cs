using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Quarter : Coin
{
    public Transform scale;
    private Transform bigScale;
    private Transform smallScale;
    private XRGrabInteractable xRGrabInteractable;
    private bool isHeld = false;
    private bool isBig = true;
    private bool isSmall = false;
    public float changeRate = .1f;

    // Start is called before the first frame update
    void Start()
    {
        scale.localScale = new UnityEngine.Vector3(1, 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
      if(isHeld)
      {
        if(!isSmall)
        {
            //Shrink();
        }
      }
      else
      {
        if(!isBig)
        {
            //Grow();
        }
      }
      gameObject.transform.localScale = scale.localScale;
    }

    public void Grow()
    {
       if(gameObject.transform.localScale != bigScale.localScale)
       {
        Debug.Log("Growing");
        scale.localScale += new UnityEngine.Vector3(changeRate,changeRate,changeRate);
       }
       else
       {
            isBig = true;
       }
        
    }
    public void Shrink()
    {
        if(gameObject.transform.localScale != smallScale.localScale)
        {
            Debug.Log("Shrinking");
            scale.localScale -= new UnityEngine.Vector3(changeRate,changeRate,changeRate);
        }
        else
        {
            isSmall = true;
        }
        
    }

    public void IsHeldSwitch()
    {
        if(isHeld){
            isHeld= false;
        }
        else{
            isHeld = true;
        }
    }
}
