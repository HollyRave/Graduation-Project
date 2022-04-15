using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }
}
