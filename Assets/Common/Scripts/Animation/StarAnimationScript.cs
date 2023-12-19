using UnityEngine;

public class StarController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        gameObject.SetActive(false); // Initially hide the star
    }

    public void ToggleStar()
    {
        bool isActive = gameObject.activeSelf;
        gameObject.SetActive(!isActive);

        if (!isActive)
        {
            animator.Play("StarSpin"); // Replace "StarSpin" with the name of your animation clip
        }
    }
}
