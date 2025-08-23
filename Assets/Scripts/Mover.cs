using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Range(0, 5)] private float _moveSpeed = 1;

    public void Move(Vector3 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, _moveSpeed * Time.deltaTime);
    }
}
