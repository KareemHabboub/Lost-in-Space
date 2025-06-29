///
// Lost In Space
// ICS4U-03
// Avery Poon
// Manages the launch of the object from the slingshot
// History:
// 2023-05-04: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Public variables accessible from other scripts
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public PolygonCollider2D col;
    [HideInInspector] public Vector3 pos {get {return transform.position; }}

    void Awake ()
    /*
    Performs initialization tasks for the object.

        Returns:
            None
    */
    {
        // Get the Rigidbody2D component attached to this object
        rb = GetComponent<Rigidbody2D> ();
        // Get the PolygonCollider2D component attached to this object
        col = GetComponent<PolygonCollider2D> ();
    }

    public void Push(Vector2 force)
    /*
    Applies a force to the object.

    Args:
        force(Vector2) : The force to be applied.

    Returns:
        None
    */
    {
        //adds the pushforce
        rb.AddForce (force, ForceMode2D.Impulse);

    }

    public void ActivateRb()
    /*
    Activates physics for the object by disabling kinematic mode.

        Returns:
            None
    */
    {
        // Enable physics for the object
        rb.isKinematic = false;
    }

    public void DeactivateRb()
    /*
    Deactivates physics for the object.

        Returns:
            None
    */
    {
        // Set velocity to zero to stop linear movement
        rb.velocity = Vector3.zero;
        // Set angular velocity to zero to stop rotational movement
        rb.angularVelocity = 0f;
        // Disable physics
        rb.isKinematic = true;
    }
}
