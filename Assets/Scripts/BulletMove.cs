using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
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

    // 충돌한 대상이 "Enemy"라는 이름이면 그 게임 오브젝트를 제거한다.


    // 충돌한 대상에 상관없이 자신을 제거한다.


}
