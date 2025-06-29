///
//Lost In Space
//ICS4U-03
//Kareem Habboub
//This program manages and saves background music and SFX.
//History:
//2023-04-2: Program Creation
//2023-05-14: Added SFX instead of only BGM
///

using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour 
{
    //Variable Declarations
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private int firstPlayInt;
    public Slider soundEffectsSlider;
    private float soundEffectsFloat;
    public AudioSource[] soundEffectsAudio;

    private void Start() 
    {
    // Retrieve the value of the "FirstPlay" key from the player preferences
    firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

    if (firstPlayInt == 0) 
    {
        // Set the initial value for sound effects volume
        soundEffectsFloat = .75f;
        // Set the slider value to match the initial sound effects volume
        soundEffectsSlider.value = soundEffectsFloat;
        // Save the initial sound effects volume to player preferences
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
        // Update the "FirstPlay" key to indicate that it has been initialized
        PlayerPrefs.SetInt(FirstPlay, -1);
    } 
    else 
    {
        // Retrieve the sound effects volume from player preferences
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
        // Set the slider value to match the saved sound effects volume
        soundEffectsSlider.value = soundEffectsFloat;
    }
    }


    public void SaveSoundSettings() 
    {
        /*
        Saves the sound settings.
        */
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsSlider.value);
    }

    void OnApplicationFocus(bool inFocus)
    {
        /*
        Callback when the application focus changes.
        Saves the sound settings if the application loses focus.
        
        Args:
            inFocus: bool - Indicates whether the application is in focus or not.
        */
        if (!inFocus) 
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound() 
    {
    /*
    Updates the sound effects volume based on the slider value.
    */
    // Iterate through each sound effect audio source
    for (int i = 0; i < soundEffectsAudio.Length; i++)
    {
        // Update the volume of the current sound effect audio source
        soundEffectsAudio[i].volume = soundEffectsSlider.value;
    }
    }
}
