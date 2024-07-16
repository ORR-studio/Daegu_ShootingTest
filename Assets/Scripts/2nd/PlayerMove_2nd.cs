using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_2nd : MonoBehaviour
{
    // ������� �Է�(WSAD)�� �޾Ƽ� �� ������ �̵��ϰ� �ʹ�.
    public float moveSpeed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
