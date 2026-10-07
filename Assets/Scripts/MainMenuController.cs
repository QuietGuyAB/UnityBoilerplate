using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void GoTOLevel()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
