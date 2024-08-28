using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerFire_4th : MonoBehaviour
{
    public Text text_results;
    public GameObject grenadePrefab;
    public Transform firePos;
    public float throwPower = 10;

    void Start()
    {
        
    }

    void Update()
    {
        FireType1();
        FireType2();
    }

    private void FireType1()
    {
        // ����, ���콺 ���� ��ư�� �����ٸ�...
        if (Input.GetMouseButtonDown(0))
        {
        // Raycast ����� �̿��ؼ� �浹�� ����� �ִٸ� �� ���� ������Ʈ�� �̸��� UI�� ����ϰ� �ʹ�.
        // - Ray�� ĳ���� ��ġ�� ����: ���� ī�޶��� ��ġ���� ���� ī�޶��� �������� �߻�
        // - ĳ���� �Ÿ�: 100����
        // - Layer Mask: 6�� ���̾�(Player)�� ������ ��� ���̾ ����
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, ~(1 << 6)))
            {
                text_results.text = hit.collider.name;
                text_results.text = hit.transform.gameObject.name;
            }
        }

    }

    private void FireType2()
    {
        // ����, ���콺 ���� ��ư�� �����ٸ�...
        if (Input.GetMouseButtonDown(1))
        {
             // 1. firePos�� ��ġ���� ����ź�� �����Ѵ�.
             // - ����ź ������ ����: grenadePrefab
            GameObject go = Instantiate(grenadePrefab, firePos.position, Quaternion.identity);

        // 2. ���� ���� 45�� �������� �������� ��(Inpulse Ÿ��)�� ���Ѵ�.
        // - ������ �� ����: throwPower
            Vector3 dir = (transform.up + go.transform.forward).normalized;
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.AddForce(dir * throwPower, ForceMode.Impulse);
        }

    }
}
