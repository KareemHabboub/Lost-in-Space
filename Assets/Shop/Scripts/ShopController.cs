///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program updates the coins text and selected skin image in the shop, while also allowing the values to be saved and shown in the Inspector.
//History:
//2023-05-28: Program Creation
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    //SerialzieFields (allows the values of those fields to be saved and shown in the Inspector)
    [SerializeField] private Image selectedSkin;
    [SerializeField] private Text coinsText;
    [SerializeField] private SkinManager skinManager;

    void Update()
    {
      /* 
      Update the coins text and selected skin image.
      */
      coinsText.text = "" + PlayerPrefs.GetInt("Coins");
      selectedSkin.sprite = skinManager.GetSelectedSkin().sprite;
    }
}
