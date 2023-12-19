using UnityEngine;
using UnityEngine.Video; // Required for video playback

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign in the inspector
    public Renderer iconRenderer; // Reference to the Renderer component of the Quad
    public Material playIconMaterial; // Assign in inspector
    public Material cancelIconMaterial; // Assign in inspector
    public GameObject videoCanvas; // Assign the canvas GameObject in the inspector

    private bool isVideoPlaying = false;

    public void ToggleVideoPlayback()
    {
        if (!isVideoPlaying)
        {
            videoPlayer.Play();
            iconRenderer.material = cancelIconMaterial; // Set material to "Cancel"
            videoCanvas.SetActive(true); // Show the video canvas
            isVideoPlaying = true;
        }
        else
        {
            videoPlayer.Stop();
            videoCanvas.SetActive(false); // Hide the video canvas
            iconRenderer.material = playIconMaterial; // Set material back to "Play"
            isVideoPlaying = false;
        }
    }
}
