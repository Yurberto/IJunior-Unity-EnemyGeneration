using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;
    [SerializeField, Range(1, 10)] private float _spawnDelay;

    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        var wait = new WaitForSeconds(_spawnDelay);

        while (enabled)
        {
            yield return wait;
            Spawn();
        }
    }

    private void Spawn()
    {
        int randomIndex = Random.Range(0, _spawners.Count);

        _spawners[randomIndex].Spawn();

    }
}
