
using UnityEngine;
using UnityEngine.SceneManagement;

public class LolaCutsceneScript : MonoBehaviour
{
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasTriggered) return;

        if (other.CompareTag("Player"))
        {
            hasTriggered = true;
            PlayerReturnData.SavedPosition = other.transform.position;
            PlayerReturnData.SavedRotation = other.transform.rotation;
            PlayerReturnData.HasSavedPosition = true;
            FindObjectOfType<QuestManager>().CompleteQuest();
            SceneManager.LoadScene(
             "LolaCutscene",
             LoadSceneMode.Additive
         );

        }
    }
}
