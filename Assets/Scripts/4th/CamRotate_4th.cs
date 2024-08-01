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

        // 마우스 상하 회전 함수
        RotatePitch();
    }

    void FollowTarget(Transform target)
    {
        transform.position = target.position;
    }

    void RotatePitch()
    {
        // 1. 마우스를 상하로 드래그하는 방향에 맞춰 카메라를 상하로 회전시키고 싶다.
        // 2. 단, 카메라의 상하 회전은 30도를 초과할 수 없다.
        // - 회전 속도 변수: rotSpeed
        // - 마우스 회전 값 누적 변수: my
        // - 상하 제한 각도 변수: angleLimit



    }

}
