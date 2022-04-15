using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] private Object _prefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawn;

    private float _elapsedTime = 0;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeBetweenSpawn)
        {
            _elapsedTime = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(_prefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)]);
    }
}
