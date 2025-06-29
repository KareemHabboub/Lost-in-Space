///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// Used for features attached to wormhole object: Detecting win and win rewards.
// History:
// 2023-05-10: Program Creation
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WormholeScript : MonoBehaviour
{
    // set values
    public Image winscreen;
    public bool win = false;

    // detecting collisions
    public void OnTriggerEnter2D(Collider2D other){
    if (other.gameObject.tag.Equals("Player")) // make sure its the player
    {
        win = true;
        int coins = PlayerPrefs.GetInt("Coins", 0); // Retrieve current coins from PlayerPrefs
        PlayerPrefs.SetInt("Coins", coins += 1000); // Update coins with additional 1000
        PlayerPrefs.Save(); // Save the changes

    }

    }

    void Update(){
    // if not win unfreeze game and disable image
    if(!win){
        winscreen.enabled = false;
        Time.timeScale = 1;
    }
    // if win freeze game and enable image
    if(win){
        winscreen.enabled = true;
        ReadyButton.ready = false;
        Time.timeScale = 0;
        }
    }

}
