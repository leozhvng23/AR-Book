using UnityEngine;

public class ToggleStarVisibility : MonoBehaviour
{
    public GameObject star; // Assign your 3D star GameObject in the Inspector

    // Method to toggle the visibility of the star
    public void ToggleVisibility()
    {
        if (star != null)
        {
            star.SetActive(!star.activeSelf); // Toggle the active state of the star
        }
    }
}