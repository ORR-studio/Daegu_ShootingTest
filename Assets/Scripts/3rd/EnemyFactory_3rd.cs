using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory_3rd : MonoBehaviour
{
    // 2�ʿ� �� ���� ���ʹ� �������� ���� �����ϰ� �ʹ�.
    public float delayTime = 2.0f;
    public GameObject enemyPrefab;

    float currentTime = 0;

    void Start()
    {
        
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > delayTime)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            currentTime = 0;
        }
    }
}
