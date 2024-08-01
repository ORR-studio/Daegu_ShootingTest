using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate_4th : MonoBehaviour
{
    public float rotSpeed = 350.0f;
    public Transform target;
    public float angleLimit = 30;

    float my = 0;

    void Start()
    {
        transform.rotation = target.rotation;
    }

    void LateUpdate()
    {
        FollowTarget(target);

        // ���콺 ���� ȸ�� �Լ�
        RotatePitch();
    }

    void FollowTarget(Transform target)
    {
        transform.position = target.position;
    }

    void RotatePitch()
    {
        // 1. ���콺�� ���Ϸ� �巡���ϴ� ���⿡ ���� ī�޶� ���Ϸ� ȸ����Ű�� �ʹ�.
        // 2. ��, ī�޶��� ���� ȸ���� 30���� �ʰ��� �� ����.
        // - ȸ�� �ӵ� ����: rotSpeed
        // - ���콺 ȸ�� �� ���� ����: my
        // - ���� ���� ���� ����: angleLimit



    }

}
