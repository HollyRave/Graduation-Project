using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class HeroMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _leftPosition;
    [SerializeField] private Vector2 _rightPosition;

    private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveHero(_leftPosition);
            _sprite.flipY = false; 
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveHero(_rightPosition);
            _sprite.flipY = true;
        }
    }

    private void MoveHero(Vector2 direction)
    {
        transform.DOMoveX(direction.x, _speed * Time.deltaTime);
    }
}
