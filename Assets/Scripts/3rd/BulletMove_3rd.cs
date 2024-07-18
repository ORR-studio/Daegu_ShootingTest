using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove_3rd : MonoBehaviour
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


    private void OnTriggerEnter(Collider other)
    {

        // �浹�� ����� "Enemy"��� �̸��̸� �� ���� ������Ʈ�� �����Ѵ�.
        if (other.gameObject.name.Contains("Enemy"))
        {
            Destroy(other.gameObject);

            // GameManager Ŭ������ ������ ���� ���� �Լ��� �����Ѵ�(1ȸ ���� �ø��� 2����).

        }

        // �浹�� ��� ������� �ڽ��� �����Ѵ�.
        Destroy(gameObject);
    }

}
