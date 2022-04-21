using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    public event UnityAction Died;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Obstacle>(out Obstacle obstacle))
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
        Died?.Invoke();
    }
}
