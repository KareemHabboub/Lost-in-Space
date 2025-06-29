///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// This script handles the audio settings, specifically the sound effects volume.
// History:
// 2023-05-20: Program Creation
///

using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float soundEffectsFloat;
    public AudioSource[] soundEffectsAudio;

    void Awake()
    {
        /*
        Awake is called when the script instance is being loaded.
        Calls the method to continue the saved audio settings.
        */
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        /*
        Continues the audio settings from the saved preferences.
        Retrieves the sound effects volume from the player preferences and applies it to each sound effect audio source.
        */
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);

        for(int i = 0; i < soundEffectsAudio.Length; i++)
        {
            // Set the volume of the current sound effect audio source
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    }
}
