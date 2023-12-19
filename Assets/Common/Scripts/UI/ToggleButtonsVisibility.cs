using UnityEngine;
using UnityEngine.UI; // For UI components

public class ToggleButtonsVisibility : MonoBehaviour
{
    public Button[] buttonsToToggle; // Assign all buttons you want to toggle in the inspector

    // Method to toggle the visibility of buttons
    public void ToggleVisibility()
    {
        foreach (var button in buttonsToToggle)
        {
            button.gameObject.SetActive(!button.gameObject.activeSelf);
        }
    }
}
