using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;

    private Coroutine _coroutine;
    private float spawnTimer = 0;
    public void Start()
    {
       // _coroutine = StartCoroutine(Co_SpawnEnemies(2.0f));
        //Co_SpawnEnemies(); //Cant call like a normal function

       // StopCoroutine(_coroutine); //Stop a instance of a coroutine
       // StopAllCoroutines(); //Stop all coroutines
    }
    private void Update()
    {
        //Custom timer
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= 2.0f)
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            spawnTimer = 0;
        }
    }
    private IEnumerator Co_Other()
    {
        yield return new WaitForSeconds(1.0f);

    }
    private IEnumerator Co_SpawnEnemies(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            yield return Co_Other();
            Enemy enemy2 = Instantiate(_enemyPrefab, transform.position, transform.rotation);
        }
    }
}
