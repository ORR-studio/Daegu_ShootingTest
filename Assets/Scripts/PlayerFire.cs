using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ����ڰ� ���콺 ���� ��ư�� Ŭ���ϸ� �Ѿ� �������� ���� �����ϰ� �ʹ�.
    public GameObject bulletPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(bulletPrefab);
            go.transform.position = transform.position;
        }
    }
}
