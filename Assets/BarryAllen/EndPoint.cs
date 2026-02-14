using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    [SerializeField] float delayLoad = 0.5f;
    [SerializeField] ParticleSystem activateParticle;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            activateParticle.Play();
            GetComponent<AudioSource>().Play();
            Invoke("delayScene", delayLoad);
        }
        
    }

    void delayScene()
    {
        SceneManager.LoadScene(0);
    }
}
