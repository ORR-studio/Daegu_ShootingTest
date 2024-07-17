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
        // �Ʒ��� �������� ��� �̵��ϰ� �ʹ�.
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ����� �±װ� "PlayerObject"��� Player ������Ʈ�� �����Ѵ�.
        if (other.gameObject.CompareTag("PlayerObject"))
        {
            Destroy(other.gameObject);

            // ���� ���� �� �����Ѵ�.


        }

        // �浹�� ��� ������� �ڱ� �ڽ��� �����Ѵ�.
        Destroy(gameObject);
    }


}
