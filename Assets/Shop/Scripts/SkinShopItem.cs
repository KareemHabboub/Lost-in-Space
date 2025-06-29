///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program the code manages the behavior of a skin item in a shop, including displaying the skin's image, updating the UI based on its locked/unlocked status, and handling events when the item or buy button is pressed.
//History:
//2023-05-28: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinShopItem : MonoBehaviour
{
    [SerializeField] private SkinManager skinManager;
    [SerializeField] private int skinIndex;
    [SerializeField] private Button buyButton;
    [SerializeField] private Text costText;
    private Skin skin;

    void Start()
    {
        /*
        Assigns the skin to the item, sets the item's image sprite, and updates the UI to show the buy button and cost text based on whether the skin is unlocked or not.
        */
        skin = skinManager.skins[skinIndex];

        GetComponent<Image>().sprite = skin.sprite;

        // Check if the skin is unlocked and update the UI accordingly
        if (skinManager.IsUnlocked(skinIndex))
        {
            buyButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            costText.text = skin.cost.ToString();
        }
    }

    public void OnSkinPressed()
    /*
    Called when the skin item is pressed.
    */
    {
        if (skinManager.IsUnlocked(skinIndex))
        {
            skinManager.SelectSkin(skinIndex);
        }
    }

    public void OnBuyButtonPressed()
    {
        /*
        Called when the buy button is pressed.
        */
        int coins = PlayerPrefs.GetInt("Coins", 0);

        // Unlock the skin if enough coins are available and the skin is not already unlocked
        if (coins >= skin.cost && !skinManager.IsUnlocked(skinIndex))
        {
            PlayerPrefs.SetInt("Coins", coins - skin.cost);
            skinManager.Unlock(skinIndex);
            buyButton.gameObject.SetActive(false);
            skinManager.SelectSkin(skinIndex);
        }
        else
        {
            Debug.Log("Not enough coins :(");
        }
    }
}
