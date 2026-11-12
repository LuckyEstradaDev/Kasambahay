using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene("Playground");
    }

    public void LoadLolaTransition()
    {
        SceneManager.LoadScene(
             "IntroCutscene",
             LoadSceneMode.Additive
         );
    }

    public void ReturnToGame()
    {
        SceneManager.UnloadSceneAsync("LolaCutscene");
    }
}
