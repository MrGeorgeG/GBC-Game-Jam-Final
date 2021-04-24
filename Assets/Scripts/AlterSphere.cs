using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AlterSphere : MonoBehaviour
{
    [SerializeField] ParticleSystem Particle;

    public Material MAlter;
    public AudioSource GitSun;
    //int index = Random.Range(0, 3);

    private void OnTriggerEnter(Collider Col)
    {

        if (Col.tag == "Player")
        {
            //Particle.Play();

            Instantiate(GitSun, gameObject.transform.position, Quaternion.identity);
        }
    }
}
