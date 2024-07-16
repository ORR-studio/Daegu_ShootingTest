using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_2nd : MonoBehaviour
{
    // 사용자의 입력(WSAD)을 받아서 그 방향대로 이동하고 싶다.
    public float moveSpeed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
