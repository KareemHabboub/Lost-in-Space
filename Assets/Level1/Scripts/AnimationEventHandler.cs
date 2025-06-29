using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationEventHandler : MonoBehaviour
{
    // This method is called when the animation event is triggered
    public void ResetScene()
    {
        ReadyButton.ready = false;
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
