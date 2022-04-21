using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : ObstaclePool
{
    [SerializeField] private GameObject _trap;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _leftSpawnPoint;
    [SerializeField] private Transform _rightSpawnPoint;
    [SerializeField] private float _timeBetweenSpawn;

    private float _elapsedTime = 0;
    private SpriteRenderer _sprite;

    private void Start()
    {
        Initialize(_trap, _pool);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                {
                    _elapsedTime = 0;
                    SetEnemy(enemy);
                }
            }
        }
    }

    private void SetEnemy(GameObject enemy)
    {
        _sprite = enemy.GetComponent<SpriteRenderer>();

        if (Random.Range(0, _spawnPoints.Length) == 0)
        {
            enemy.SetActive(true);
            _sprite.flipY = false;
            enemy.transform.position = _leftSpawnPoint.position;
        }
        else
        {
            enemy.SetActive(true);
            _sprite.flipY = true;
            enemy.transform.position = _rightSpawnPoint.position;
        }
    }
}