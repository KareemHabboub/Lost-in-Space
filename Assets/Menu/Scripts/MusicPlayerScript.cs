///
// Lost In Space
// ICS4U-03
// Kareem Habboub
// Manages the audio source volume to the users saved preference
// History:
// 2023-02-10: Program Creation
///
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    private AudioSource AudioSource;
    public GameObject ObjectMusic;
    public Slider volumeSlider;
    private float MusicVolume = 1f;

    private void Start()
    {
        /*
        Finds the audio source component and initializes the volume based on the player's saved preference.
        */
        ObjectMusic = GameObject.FindWithTag("BGM");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();
        
        //Retrieve the volume from PlayerPrefs and set the audio source volume and slider value accordingly.
        MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    private void Update()
    {
        /*
        Updates the audio source volume and saves the volume preference.
        */
        AudioSource.volume = MusicVolume;
        
        // Save the volume using PlayerPrefs, so it can be retrieved in the Start() method next time.
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void updateVolume(float volume)
    {
        /*
        Updates the music volume based on the slider value.
        Args:
            volume: float
        */
        MusicVolume = volume;
    }
}

