using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private float _moveSpeed = 10;

    private Transform _target;

    public void Initialize(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        if (_target == null)
        {
            Debug.Log("Target is not init!!!");
            Destroy(gameObject);
            return;
        }

        Move();
    }

    private void Move()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _moveSpeed * Time.deltaTime);
    }
}
