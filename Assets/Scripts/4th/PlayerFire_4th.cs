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
        // Raycast ����� �̿��ؼ� �浹�� ����� �ִٸ� �� ���� ������Ʈ�� �̸��� UI�� ����ϰ� �ʹ�.
        // - Ray�� ĳ���� ��ġ�� ����: ���� ī�޶��� ��ġ���� ���� ī�޶��� �������� �߻�
        // - ĳ���� �Ÿ�: 100����
        // - Layer Mask: 6�� ���̾�(Player)�� ������ ��� ���̾ ����


    }

    private void FireType2()
    {
        // ����, ���콺 ���� ��ư�� �����ٸ�...
        // 1. firePos�� ��ġ���� ����ź�� �����Ѵ�.
        // 2. ���� ���� 45�� �������� �������� ��(Inpulse Ÿ��)�� ���Ѵ�.
        // - ����ź ������ ����: grenadePrefab
        // - ������ �� ����: throwPower


    }
}
