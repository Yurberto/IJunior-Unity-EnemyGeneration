using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Character _prefab;
    [SerializeField] private Transform _target;

    public void Initialize(Transform target)
    {
        _target = target;
    }

    public void Spawn()
    {
        var spawnedObject = Instantiate(_prefab, transform.position, Quaternion.identity);
        spawnedObject.Initialize(_target);
    }
}
