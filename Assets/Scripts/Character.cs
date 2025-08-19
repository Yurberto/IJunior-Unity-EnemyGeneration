using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private float _moveSpeed = 10;

    private Vector3 _direction;

    public void Initialize(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        if (_direction == null)
        {
            Debug.Log("Direction is not init!!!");
            Destroy(gameObject);
            return;
        }

        Move();
    }

    private void Move()
    {
        transform.position += _direction.normalized * (_moveSpeed * Time.deltaTime);
    }
}
