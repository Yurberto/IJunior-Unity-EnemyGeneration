using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;

    private Mover _mover;
    private int _currentWaypoint;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWaypoint].position)
            _currentWaypoint = (_currentWaypoint + 1) % _wayPoints.Length;

        _mover.Move(_wayPoints[_currentWaypoint].position);
    }
}
