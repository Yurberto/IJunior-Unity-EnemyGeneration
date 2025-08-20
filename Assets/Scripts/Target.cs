using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField, Range (-10, 10)] private float _speed = 5;

    private int _currentWaypoint;

    private void Update()
    {
        if (_speed == 0)
            return;

        if (transform.position == _wayPoints[_currentWaypoint].position)
            _currentWaypoint = (_currentWaypoint + 1) % _wayPoints.Length;

        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWaypoint].position, _speed * Time.deltaTime);
    }
}
