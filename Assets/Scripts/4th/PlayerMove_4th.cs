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
        // ���콺�� �¿�� �巡���ϴ� ���⿡ ���� ĳ���͸� �¿�� ȸ����Ű�� �ʹ�.
        // - ȸ�� �ӵ� ����: rotSpeed
        // - ���콺 ȸ�� �� ���� ����: mx
        float a = Input.GetAxis("Mouse X");
        mx += a * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);

    }

}
