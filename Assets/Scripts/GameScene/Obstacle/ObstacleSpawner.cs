using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Object _leftTrap;
    [SerializeField] private Object _rightTrap;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _leftSpawnPoint;
    [SerializeField] private Transform _rightSpawnPoint;
    [SerializeField] private float _timeBetweenSpawn;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        Debug.Log(Time.deltaTime);

        if (_elapsedTime >= _timeBetweenSpawn)
        {
            _elapsedTime = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        if (Random.Range(0, _spawnPoints.Length) == 0)
        {
            Instantiate(_leftTrap, _leftSpawnPoint);
        }
        else
        {
            Instantiate(_rightTrap, _rightSpawnPoint);
        }
    }
}
