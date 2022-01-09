using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldController : MonoBehaviour
{
    public GameObject[] enemy = new GameObject[3];
    float currentTime = 10.1f;
    float maxTime = 10f;
    int RandomEnemyies;

    private void Awake()
    {
        enemyAction();
    }
    private void Update()
    {
        enemyAction();
    }

    public void enemyAction()
    {

        RandomEnemy();
        EnemyTime();

        if (currentTime > maxTime)
        {
            Instantiate(enemy[RandomEnemyies], transform.position, transform.rotation);
            currentTime = 0;
        }

    }
    public int RandomEnemy()
    {
        RandomEnemyies = Random.Range(0, 3);
        return RandomEnemyies;
    }
    public void EnemyTime()
    {
        currentTime += Time.deltaTime;
    }
}
