using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove_3rd : MonoBehaviour
{
    public float moveSpeed = 10;


    void Start()
    {

    }

    void Update()
    {
        // 아래쪽 방향으로 계속 이동하고 싶다.
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 대상의 태그가 "PlayerObject"라면 Player 오브젝트를 제거한다.
        if (other.gameObject.CompareTag("PlayerObject"))
        {
            Destroy(other.gameObject);

            // 현재 씬을 재 시작한다.


        }

        // 충돌한 대상에 관계없이 자기 자신을 제거한다.
        Destroy(gameObject);
    }


}
