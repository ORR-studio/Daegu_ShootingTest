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
        // 만일, 마우스 좌측 버튼을 눌렀다면...
        if (Input.GetMouseButtonDown(0))
        {
        // Raycast 기능을 이용해서 충돌한 대상이 있다면 그 게임 오브젝트의 이름을 UI에 출력하고 싶다.
        // - Ray의 캐스팅 위치와 방향: 메인 카메라의 위치에서 메인 카메라의 전방으로 발사
        // - 캐스팅 거리: 100미터
        // - Layer Mask: 6번 레이어(Player)를 제외한 모든 레이어를 감지
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
        // 만일, 마우스 우측 버튼을 눌렀다면...
        if (Input.GetMouseButtonDown(1))
        {
             // 1. firePos의 위치에서 수류탄을 생성한다.
             // - 수류탄 프리팹 변수: grenadePrefab
            GameObject go = Instantiate(grenadePrefab, firePos.position, Quaternion.identity);

        // 2. 전방 위쪽 45도 방향으로 물리적인 힘(Inpulse 타입)을 가한다.
        // - 던지는 힘 변수: throwPower
            Vector3 dir = (transform.up + go.transform.forward).normalized;
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.AddForce(dir * throwPower, ForceMode.Impulse);
        }

    }
}
