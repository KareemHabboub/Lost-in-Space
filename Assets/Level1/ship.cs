///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program handles player collision and adds an audio + animation when collision is detected.
//History:
//2023-06-03: Program Creation
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour {
    public GameObject explosionPrefab;
    public RectTransform canvasRectTransform; // Reference to the canvas RectTransform
    public AudioSource collisionAudioSource; // Reference to the audio source

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (ReadyButton.ready == true)
        {
            if (other.gameObject.CompareTag("SpikeyBall") || other.gameObject.CompareTag("Border") || other.gameObject.CompareTag("Planet"))
            {
                Debug.Log("hit detected");

                // Instantiate the explosion as a child of the canvas
                GameObject explosion = Instantiate(explosionPrefab, canvasRectTransform);
                PlayCollisionSound();
                // Set the explosion's position to match the ship's position
                explosion.transform.position = transform.position;

                this.gameObject.SetActive(false);
            }
        }
    }


    private void PlayCollisionSound()
    {
        /*
        Plays the collision sound if the audio source reference is not null.
        */
        if (collisionAudioSource != null)
            collisionAudioSource.Play();
    }
}
