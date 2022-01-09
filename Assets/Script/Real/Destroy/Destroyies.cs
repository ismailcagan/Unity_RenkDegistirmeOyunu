using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyies : MonoBehaviour
{
    float currentTime;
    float maxTime = 10f;
    int destroyIndex;

    private void Start()
    {
        
    }
    private void Update()
    {
        DestroyEnemy();
    }

    public void DestroyEnemy()
    {
        currentTime += Time.deltaTime;

        if (currentTime > maxTime)
        {
            Destroy(gameObject);
        }
    }
}
