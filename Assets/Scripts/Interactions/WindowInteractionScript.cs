
using UnityEngine;

public class WindowInteractionScript : MonoBehaviour
{
    public Transform windowPanel;
    public float slideDistance = 1f;
    public float openSpeed = 3f;

    private Vector3 closedPosition;
    private Vector3 openPosition;
    private bool isOpen = false;

    void Start()
    {
        if (windowPanel == null)
        {
            Debug.LogError("WindowPanel is not assigned!");
            return;
        }

        closedPosition = windowPanel.localPosition;
        openPosition = closedPosition +
            new Vector3(slideDistance, 0f, 0f);
    }

    void Update()
    {
        if (windowPanel == null) return;

        Vector3 targetPosition = isOpen
            ? openPosition
            : closedPosition;

        windowPanel.localPosition = Vector3.Lerp(
            windowPanel.localPosition,
            targetPosition,
            Time.deltaTime * openSpeed
        );
    }

    public void ToggleWindow()
    {
        isOpen = !isOpen;
        Debug.Log("Window toggled: " + (isOpen ? "Open" : "Closed"));
    }
}
