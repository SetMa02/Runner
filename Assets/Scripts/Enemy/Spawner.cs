using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private Transform[] _spawnPoints;

    private float _elapseTime = 0;


    private void Start()
    {
        Initialize(_enemyPrefab);
    }

    private void Update()
    {
        _elapseTime += Time.deltaTime;
        if(_elapseTime >= _secondsBetweenSpawn)
        {
            if(TryGetObject(out GameObject enemy))
            {
                _elapseTime = 0;

               int spawnPointNumer = Random.Range(0, _spawnPoints.Length);
                Instantiate(_enemyPrefab, _spawnPoints[spawnPointNumer]);

                SetEnemy(enemy, _spawnPoints[spawnPointNumer].position);
       
            }
        }

            
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
