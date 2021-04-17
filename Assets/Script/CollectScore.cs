using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Debug.Log("Add Points");
        ScoreSystem.theScore += 10;
        Destroy(gameObject);
    }
}
