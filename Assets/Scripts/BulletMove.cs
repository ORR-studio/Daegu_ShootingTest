using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // ���� �������� ��� �̵��ϰ� �ʹ�.
    public float moveSpeed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }

    // �浹�� ����� "Enemy"��� �̸��̸� �� ���� ������Ʈ�� �����Ѵ�.


    // �浹�� ��� ������� �ڽ��� �����Ѵ�.


}
