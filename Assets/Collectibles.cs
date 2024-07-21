using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to the game object
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided is the player
        if (other.CompareTag("Player"))
        {
            // Play the sound effect
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }

            // Make the game object disappear
            gameObject.SetActive(false);
        }
    }
}
