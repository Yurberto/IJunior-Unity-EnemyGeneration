using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Character _prefab;
    [SerializeField] private Vector3 _runDirection;

    public void Spawn()
    {
        var newObject = Instantiate(_prefab, transform.position, Quaternion.identity);
        newObject.Initialize(_runDirection);
    }
}
