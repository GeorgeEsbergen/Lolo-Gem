// This Script will collect your gem


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedGem : MonoBehaviour
{

    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 250;
        collectSound.Play();
        Destroy(gameObject);
    }
}