using UnityEngine;
using DG.Tweening;

public class HeroMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _leftPosition;
    [SerializeField] private Vector2 _rightPosition;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveHero(_leftPosition);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveHero(_rightPosition);
        }
    }

    private void MoveHero(Vector2 direction)
    {
        transform.DOMoveX(direction.x, _speed * Time.deltaTime);
    }
}
