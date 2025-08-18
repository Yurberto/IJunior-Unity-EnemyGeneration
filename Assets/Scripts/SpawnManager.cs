using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;
    [SerializeField, Range(1, 10)] private float _spawnDelay;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0.0f, _spawnDelay);
    }

    private void Spawn()
    {
        int randomIndex = Random.Range(0, _spawners.Count);

        _spawners[randomIndex].Spawn();
    }
}
