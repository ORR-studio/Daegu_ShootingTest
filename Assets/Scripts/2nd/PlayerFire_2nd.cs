using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire_2nd : MonoBehaviour
{
    // ����ڰ� ���콺 ���� ��ư�� Ŭ���ϸ� �Ѿ� �������� ���� �����ϰ� �ʹ�.
    public GameObject bulletPrefab;
    public Transform firePos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(bulletPrefab);
            go.transform.position = firePos.position;
        }
    }
}
