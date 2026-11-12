
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractionScript : MonoBehaviour
{
    public float interactionDistance = 3f;
    public Camera playerCamera;

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.eKey.wasPressedThisFrame)
        {
            UnityEngine.Debug.Log("E key pressed!");

            Ray ray = new Ray(
                playerCamera.transform.position,
                playerCamera.transform.forward
            );

            if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance))
            {
                UnityEngine.Debug.Log("Raycast hit: " + hit.collider.name);

                WindowInteractionScript window =
                    hit.collider.GetComponentInParent<WindowInteractionScript>();

                if (window != null)
                {
                    UnityEngine.Debug.Log("Window script found!");
                    window.ToggleWindow();
                }
                else
                {
                    UnityEngine.Debug.Log("No WindowInteractionScript found!");
                }
            }
            else
            {
                UnityEngine.Debug.Log("Raycast did not hit anything!");
            }
        }
    }
}
