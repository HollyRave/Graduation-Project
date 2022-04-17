using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
