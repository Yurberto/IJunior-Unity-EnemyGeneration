using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Character _prefab;
    [SerializeField] private Transform _target;

    public void Spawn()
    {
        var newObject = Instantiate(_prefab, transform.position, Quaternion.identity);
        newObject.Initialize(_target);
    }
}
