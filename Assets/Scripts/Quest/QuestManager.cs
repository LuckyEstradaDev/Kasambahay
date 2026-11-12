
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public QuestUI questUI;

    private int currentQuest = 0;

    void Start()
    {
        UpdateCurrentQuest();
    }

    public void CompleteQuest()
    {
        currentQuest++;

        UpdateCurrentQuest();
    }

    void UpdateCurrentQuest()
    {
        switch (currentQuest)
        {
            case 0:
                questUI.UpdateQuest(
                    "Objectives",
                    "Find Lola Esperanza."
                );
                break;

            case 1:
                questUI.UpdateQuest(
                    "Objectives",
                    "Open the window."
                );
                break;

            case 2:
                questUI.UpdateQuest(
                    "Unlock the Second Floor",
                    "Find and unlock the upstairs door."
                );
                break;

            case 3:
                questUI.UpdateQuest(
                    "Investigate the Bedroom",
                    "Inspect the bedroom upstairs."
                );
                break;

            default:
                questUI.UpdateQuest(
                    "Objectives Completed",
                    "Wait for further instructions."
                );
                break;
        }
    }
}
