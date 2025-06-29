///
// Lost In Space
// ICS4U-03
// Avery Poon
// Managaes the onclick Drag and Drop feature of the planets
// History:
// 2023-03-13: Program Creation
///
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler {

    // importing the gameobject's components
    private CircleCollider2D _col;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    //keeping track of the gameobject's initial position
    Vector2 initialPosition;


    void Start()
    /*
    Initializes the object by disabling the CircleCollider2D hitbox.

    Returns:
        None
    */
    {
        _col = GetComponent<CircleCollider2D>();
        //hitbox is enabled
        _col.enabled = false;
    }

    private void Awake() {
    /*
    Performs initialization tasks for the object.

    Returns:
        None
    */
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData) {
    /*
        Executes when a drag operation begins.

    Args:
        eventData(PointerEventData): The event data associated with the drag operation.

   Returns:
        None
    */
       //hitbox is enabled
       _col.enabled = false;
        // transparency is 0.6/1
        canvasGroup.alpha = .6f;
    }

    public void OnDrag(PointerEventData eventData) {
    /*
    Executes when the object is being dragged.

    Args:
        eventData(PointerEventData): The event data associated with the drag operation.

    Returns:
        None
    */
        //hitbox is enabled
       _col.enabled = false;
        //objects moves where mouose moves
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData) {
    /*
    Executes when the drag operation ends.

    Args:
        eventData(PointerEventData): The event data associated with the drag operation.

    Returns:
        None
    */
       //hitbox is disabled
       _col.enabled = true;
        //transparency is back to default
        canvasGroup.alpha = 1f;
        //takes note of different location of gameobject
        initialPosition = rectTransform.anchoredPosition;    
        }

    public void OnPointerDown(PointerEventData eventData) {
    /*
        Executes when the pointer is pressed down on the object.

        Args:
        eventData(PointerEventData): The event data associated with the pointer down event.

    Returns:
        None
    */
    }

    public void OnDrop(PointerEventData eventData) {
    /*
        Executes when the object is dropped onto a drop target.

        Args:
        eventData(PointerEventData): The event data associated with the drop event.

    Returns:
        None
    */
    }
    void Update(){
    /*
        Update function that is called every frame.

        Returns:
        None
     */
        if (moving.grav == true){
            if(StartingPull.pull == true){
            // enables the circle collider
            GetComponent<CircleCollider2D>().enabled = true;
            }
        }
        if(ReadyButton.ready == true){
            // allows the player to click on the planet
            canvasGroup.blocksRaycasts = false;
        }
    }
    
}
