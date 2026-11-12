using UnityEngine;

public class RestorePlayerPosition : MonoBehaviour
{
    void Start()
    {
        if (PlayerReturnData.HasSavedPosition)
        {
            CharacterController controller =
                GetComponent<CharacterController>();

            if (controller != null)
                controller.enabled = false;

            transform.SetPositionAndRotation(
                PlayerReturnData.SavedPosition,
                PlayerReturnData.SavedRotation
            );

            if (controller != null)
                controller.enabled = true;

            PlayerReturnData.HasSavedPosition = false;
        }
    }
}