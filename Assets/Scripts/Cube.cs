using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube : MonoBehaviour
{
    [SerializeField] ParticleSystem Particle;
    [SerializeField] GameManager GM;
    public AudioSource Sun;

    private void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "Player")
        {
            Particle.Play();
            GameObject.Destroy(this.gameObject);
            Instantiate(Sun, gameObject.transform.position, Quaternion.identity);
        }
    }

    
}

