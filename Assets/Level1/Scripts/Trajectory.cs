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

public class Trajectory : MonoBehaviour
{
    //using the dots sprite in prefabs
    [SerializeField] int dotsNumber;
    [SerializeField] GameObject dotsParent;
    [SerializeField] GameObject dotPrefab;
    [SerializeField] float dotSpacing;

    Transform[] dotsList;

    Vector2 pos;
    //dot position
    float timeStamp;

    //---------------------
    void Start()
    /*
    Initializes the trajectory by hiding it and preparing the dots.

    Returns:
        None
    */
    {
        //hides the trajectory at the start
        Hide();
        PrepareDots();

    }

    void PrepareDots(){
    /*
    Creates and prepares a list of dots.

    This function creates a list of dots with a specified number of elements.Each dot is instantiated from a dotPrefab object and added to the dotsParent transform.The created list of dots is stored in the dotsList variable.

    Returns:
        None
    */
        dotsList = new Transform[dotsNumber];
        //makes a list of the dots sprite
        for (int i = 0; i < dotsNumber; i++) {
            //transforms the list of dots
            dotsList[i] = Instantiate (dotPrefab, null).transform;
            dotsList [i].parent = dotsParent.transform;
        }
    }

    public void UpdateDots(Vector3 ballPos, Vector2 forceApplied){
    /*
    Updates the positions of the dots based on the ball's position and applied force.

    Args:
        ballPos(Vector3): The position of the ball as a Vector3.
        forceApplied(Vector2): The applied force as a Vector2.

    Returns:
        None
    */
        timeStamp = dotSpacing;
        //for the number of dots, it stretches the trajectory based on the mouse movement
        for (int i = 0; i < dotsNumber; i++) {
            pos.x = (ballPos.x + forceApplied.x * timeStamp);
            pos.y = (ballPos.y + forceApplied.y * timeStamp) - (timeStamp*timeStamp) / 2f;

            dotsList [i].position = pos;
            timeStamp += dotSpacing;
        }
    }

    public void Show()
    /*
    Shows the trajectory by enabling the dotsParent object.

    Returns:
        None
    */
    {
        //allows the trajectory to be seen
        dotsParent.SetActive (true);
    }

    public void Hide ()
    /*Hides the trajectory by disabling the dotsParent object.

    Returns:
        None
    */
    {
        //hides trajectory
        dotsParent.SetActive (false);

    }
}
