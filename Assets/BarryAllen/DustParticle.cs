using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem DustParticles;
    void OnCollisionEnter2D(Collision2D other)    
    {
        if(other.gameObject.tag == "Floor")
        {
            DustParticles.Play();   
        }
        
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Floor")
        {
            DustParticles.Stop();
        }   
    }
}
