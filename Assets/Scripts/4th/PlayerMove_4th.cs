using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_4th : MonoBehaviour
{
    public float moveSpeed = 7.0f;
    public float rotSpeed = 350.0f;

    CharacterController cc;
    float mx = 0;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
        RotateYaw();
    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = transform.TransformDirection(new Vector3(h, 0, v).normalized);
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }

    void RotateYaw()
    {
        // 마우스를 좌우로 드래그하는 방향에 맞춰 캐릭터를 좌우로 회전시키고 싶다.
        // - 회전 속도 변수: rotSpeed
        // - 마우스 회전 값 누적 변수: mx
        float a = Input.GetAxis("Mouse X");
        mx += a * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);

    }

}
