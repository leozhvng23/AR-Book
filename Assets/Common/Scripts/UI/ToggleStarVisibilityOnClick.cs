using UnityEngine;

public class ToggleStarVisibilityOnClick : MonoBehaviour
{
    public GameObject star; // Assign your star GameObject in the Unity Inspector

    // Method to be called on button click
    public void OnButtonClick()
    {
        // Check if the star GameObject has been assigned
        if (star != null)
        {
            // Toggle the active state of the star
            star.SetActive(!star.activeSelf);
        }
        else
        {
            Debug.LogWarning("Star GameObject is not assigned in the Inspector");
        }
    }
}
