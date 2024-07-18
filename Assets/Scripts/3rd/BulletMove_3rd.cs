using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove_3rd : MonoBehaviour
{
    // 위쪽 방향으로 계속 이동하고 싶다.
    public float moveSpeed = 10;

    void Start()
    {

    }

    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {

        // 충돌한 대상이 "Enemy"라는 이름이면 그 게임 오브젝트를 제거한다.
        if (other.gameObject.name.Contains("Enemy"))
        {
            Destroy(other.gameObject);

            // GameManager 클래스에 구현된 점수 증가 함수를 실행한다(1회 격추 시마다 2점씩).

        }

        // 충돌한 대상에 상관없이 자신을 제거한다.
        Destroy(gameObject);
    }

}
