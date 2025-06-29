///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program defines a SkinManager class that manages skins, allowing selection, unlocking, and retrieval of skin information.
//History:
//2023-05-28: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinManager", menuName = "Skin Manager")] //creating a unity tool called SkinManager
public class SkinManager : ScriptableObject
{
    [SerializeField] public Skin[] skins;
    private const string Prefix = "Skin_";
    private const string SelectedSkin = "SelectedSkin";

    public void SelectSkin(int skinIndex)
    {
        /* 
        Sets the selected skin based on the given skin index.
        */
        PlayerPrefs.SetInt(SelectedSkin, skinIndex);
    }

    public Skin GetSelectedSkin()
    {
        /* 
        Retrieves the currently selected skin, Returns the selected skin as a Skin object.
        */
        int skinIndex = PlayerPrefs.GetInt(SelectedSkin, 0);
        if (skinIndex >= 0 && skinIndex < skins.Length)
        {
            return skins[skinIndex];
        }
        else
        {
            return null;
        }
    }

    public void Unlock(int skinIndex)
    {
        /* 
        Unlocks the skin with the specified index.
        */
        PlayerPrefs.SetInt(Prefix + skinIndex, 1);
    }

    public bool IsUnlocked(int skinIndex)
    {
        /* 
        Checks if the skin with the specified index is unlocked.
        Returns true if the skin is unlocked, false otherwise.
        */
        return PlayerPrefs.GetInt(Prefix + skinIndex, 0) == 1;
    }
}
