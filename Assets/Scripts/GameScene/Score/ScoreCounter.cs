using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _scoreGameOverScreenText;
    [SerializeField] private float _timeBetweenAward;
    [SerializeField] private int _stepScore;
    
    private float _elapsedTime;
    private int _currentScore = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeBetweenAward)
        {
            _elapsedTime = 0;
            Award();
        }
    }

    private void Award()
    {
        _currentScore += _stepScore;
        _scoreText.SetText(_currentScore.ToString());
        _scoreGameOverScreenText.SetText(_currentScore.ToString());
    }
}
