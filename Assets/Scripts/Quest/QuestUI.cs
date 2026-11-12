
using UnityEngine;
using TMPro;

public class QuestUI : MonoBehaviour
{
    public TMP_Text questTitle;
    public TMP_Text questDescription;

    public void UpdateQuest(string title, string description)
    {
        questTitle.text = title;
        questDescription.text = description;
    }
}
