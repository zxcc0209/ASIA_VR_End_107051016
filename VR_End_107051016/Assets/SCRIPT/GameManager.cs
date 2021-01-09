using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("保齡球場");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
