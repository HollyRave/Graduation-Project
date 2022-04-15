
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Вы вышли из игры");
    }
}
