using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    
    private CanvasGroup _group;

    private void Awake()
    {
        _group = GetComponent<CanvasGroup>();    
    }

    private void OnEnable()
    {
        _hero.Died += GameOver;
    }

    private void OnDisable()
    {
        _hero.Died -= GameOver;
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _group.alpha = 1;
    }
}
