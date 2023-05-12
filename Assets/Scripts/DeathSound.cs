using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public AudioSource deathSound;
    public AudioSource gameSound;
    void OnTriggerEnter()
    {
        gameSound.Stop();
        deathSound.Play();
    }
}
