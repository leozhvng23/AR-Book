using UnityEngine;

public class ToggleUIVisibility : MonoBehaviour
{
    [SerializeField]
    public GameObject[] uiElements; // Array to hold UI elements

    public TextMesh label; // Reference to the Text Mesh component on the Label GameObject

    private bool isUIOn = true; // State to track if UI is on or off

    private void Start()
    {
        // Set initial label text based on the default state
        UpdateLabel();
    }

    public void ToggleVisibility()
    {
        if (uiElements != null && uiElements.Length > 0)
        {
            foreach (var element in uiElements)
            {
                if (element != null)
                {
                    element.SetActive(!element.activeSelf);
                }
            }
        }

        // Toggle the state and update the label text
        isUIOn = !isUIOn;
        UpdateLabel();
    }

    private void UpdateLabel()
    {
        if (label != null)
        {
            label.text = isUIOn ? "Hide UI" : "UI Hidden";
        }
    }
}
