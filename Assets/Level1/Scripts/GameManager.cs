///
// Lost In Space
// ICS4U-03
// Avery Poon
// Manages the Trajectory of the player object
// History:
// 2023-05-01: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake()
    /*
    Performs initialization tasks for the object.

    Returns:
        None
    */
    {
        // Check if the Instance variable is null
        if (Instance == null)
        {
            // Set the Instance variable to reference this GameManager object
            Instance = this;
        }
    }

    Camera cam;

    // Declare a public Shoot object of type Player
    public shoot player;

    // Declare a public Trajectory object
    public Trajectory trajectory;

    // Serialize the pushForce variable to make it editable in the Unity editor
    [SerializeField] float pushForce = 4f;

    // Declare a boolean variable to track if the object is being dragged
    bool isDragging = false;

    // Declare Vector2 variables to store the start and end points of the drag
    Vector2 startPoint;
    Vector2 endPoint;

    // Declare Vector2 variables to store the direction and force of the shot
    Vector2 direction;
    Vector2 force;

    // Declare a float variable to store the distance between the start and end points of the drag
    float distance;

    // Declare two static integer variables b and x
    public static int b = 1;
    public static int x = 0;

    // Flag to track if ReadyButton.ready has been handled
    private bool isReady = false;

    // Declare a private boolean variable to track if the input has been handled
    private bool inputHandled = false;

    void Start()
    /*
    Performs initialization tasks when the object starts.

    Returns:
        None
    */
    {
        cam = Camera.main;
        player.DeactivateRb();
    }

    void Update()
    /*
    Update function that is called every frame.

        Returns:
            None
    */
    {
        // Check if the isReady flag is false and the ReadyButton.ready flag is true
        if (!isReady && ReadyButton.ready)
        {
            isReady = true;
        }

        // Check if the isReady flag is true and the inputHandled flag is false
        if (isReady && !inputHandled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isDragging = true;
                OnDragStart();
            }
            // Check if the isDragging flag is true and the left mouse button is released
            if (isDragging && Input.GetMouseButtonUp(0))
            {
                isDragging = false;
                OnDragEnd();
                inputHandled = true;
            }
            // Check if the isDragging flag is true
            if (isDragging)
            {
                OnDrag();
            }
        }
    }

    //Drag-----------------------

    // This method is called when the drag starts
    void OnDragStart()
    /*
    Executes when the drag operation starts.

        Returns:
            None
    */
    {
        // Deactivate the Rigidbody component of the player object
        player.DeactivateRb();
        // Convert the mouse position on the screen to a world position
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);

        // Show the trajectory
        trajectory.Show ();
    }
    void OnDrag()
    /*
    Executes when the object is being dragged.

        Returns:
            None
    */
    {
        // Convert the current mouse position on the screen to a world position
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        // Calculate the distance between the start and end points
        distance = Vector2.Distance(startPoint, endPoint);
        // Calculate the direction from the start point to the end point and normalize it
        direction = (startPoint - endPoint).normalized;
        // Calculate the force based on the direction, distance, and pushForce
        force = direction * distance * pushForce;

        // indicator
        Debug.DrawLine(startPoint, endPoint);

        // Update the trajectory dots based on the player's position and the calculated force
        trajectory.UpdateDots (player.pos, force);
    }
    void OnDragEnd()
    /*
    Executes when the drag operation ends.

        Returns:
            None
    */
    {
        player.ActivateRb();

        player.Push(force);

        trajectory.Hide ();
    }
}
