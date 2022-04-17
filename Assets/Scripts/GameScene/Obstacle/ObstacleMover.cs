using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }
}
