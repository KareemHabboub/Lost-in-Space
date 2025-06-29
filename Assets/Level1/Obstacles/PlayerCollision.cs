///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program  handles player collisions by detecting specific game objects, logging the collision tag, playing a collision sound, and reloading the current scene with a short delay.
//History:
//2023-05-2: Program Creation
///

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource collisionAudioSource; // Reference to the audio source

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        Checks for collision with specific game objects, logs the collision tag, plays a collision sound,
        and reloads the current scene with a short delay.
        */
        if (collision.gameObject.CompareTag("SpikeyBall") || collision.gameObject.CompareTag("SpikeyBall") || collision.gameObject.CompareTag("Border") || collision.gameObject.CompareTag("Planet"))
        {
            Debug.Log("Collision detected with: " + collision.gameObject.tag);
            PlayCollisionSound(); // Play the collision sound
            StartCoroutine(ReloadSceneWithDelay()); // Reload the current scene with a delay
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

    private IEnumerator ReloadSceneWithDelay()
    {
        /*
        Reloads the current scene with a short delay.
        */
        yield return new WaitForSeconds(0.4f); // Delay for 1/10 of a second
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        ReadyButton.ready = false;
    }
}
