///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program changes the players skin to the one they have equipped
//History:
//2023-05-29: Program Creation
///

using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // SerializeFields (allows the values of those fields to be saved and shown in the Inspector)
    [SerializeField] private SkinManager skinManager;
    [SerializeField] private Image playerImage;

    void Start()
    {
        /*
        Changes the players script to the one they have equipped
        */
        playerImage.sprite = skinManager.GetSelectedSkin().sprite;
    }
}
