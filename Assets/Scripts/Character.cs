using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider), typeof(Mover))] 
public class Character : MonoBehaviour
{
    private Mover _mover;
    private Transform _target;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

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

        transform.LookAt(_target.position);
        _mover.Move(_target.position);
    }
}
