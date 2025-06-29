///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program makes the player bounce away if they come in contact with an object
//History:
//2023-05-2: Program Creation
///

using UnityEngine;

public class BouncyScript : MonoBehaviour
{
    public float bounceForce = 10f; // Adjust this value to control the force of the bounce

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        Checks if the colliding object has the "Player" tag, and if so, applies a bounce force to it.
        */
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            
            // Calculate the direction away from the collision point
            Vector2 bounceDirection = (collision.transform.position - transform.position).normalized;
            
            // Apply the bounce force in the opposite direction
            playerRigidbody.velocity = -bounceDirection * bounceForce;
        }
    }
}
