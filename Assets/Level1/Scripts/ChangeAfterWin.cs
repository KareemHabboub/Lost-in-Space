///
// Lost In Space
// ICS4U-03
// Kyle Pollock
// Swaps scenes if player has won
// History:
// 2023-05-20: Program Creation
///
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeAfterWin: MonoBehaviour {
 
void Update(){
if(Time.timeScale == 0){ // check if player has won
    if(Input.GetKeyDown(KeyCode.Return)){ // detect key
        SceneManager.LoadScene("LevelSelect"); // swap scene
        }    
    }   
}
}