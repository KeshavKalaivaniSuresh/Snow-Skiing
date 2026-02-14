using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float BoostSpeed = 30f;
    [SerializeField] float BaseSpeed = 17.5f;
    [SerializeField] AudioClip PowerUp;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool CanMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove)
        {
            playerMovement();
            RespondToSpeed();  
        }
       
    }

    public void DisableControls()
    {
           CanMove = false;
    }

    void RespondToSpeed()
    {
         if (Input.GetKey(KeyCode.UpArrow))
         {
            GetComponent<AudioSource>().PlayOneShot(PowerUp);
            surfaceEffector2D.speed = BoostSpeed;
         }
         else 
         {
            surfaceEffector2D.speed = BaseSpeed;
         }
    }

    void playerMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
