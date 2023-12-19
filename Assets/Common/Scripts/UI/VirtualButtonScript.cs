using Vuforia;
using UnityEngine;

public class VirtualButtonScript : MonoBehaviour 
{
    public GameObject cube; // Assign your 3D cube GameObject in the inspector

    void Start()
    {
        VirtualButtonBehaviour vButton = GetComponentInChildren<VirtualButtonBehaviour>();
        if (vButton != null)
        {
            vButton.RegisterOnButtonPressed(OnButtonPressed);
            vButton.RegisterOnButtonReleased(OnButtonReleased);
        }

        cube.SetActive(false); // Initially hide the cube
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(!cube.activeInHierarchy); // Toggle the cube’s visibility
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        // Handle button release if needed
    }
}
