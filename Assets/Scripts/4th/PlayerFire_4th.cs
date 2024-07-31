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
        // Raycast 기능을 이용해서 충돌한 대상이 있다면 그 게임 오브젝트의 이름을 UI에 출력하고 싶다.
        // - Ray의 캐스팅 위치와 방향: 메인 카메라의 위치에서 메인 카메라의 전방으로 발사
        // - 캐스팅 거리: 100미터
        // - Layer Mask: 6번 레이어(Player)를 제외한 모든 레이어를 감지


    }

    private void FireType2()
    {
        // 만일, 마우스 우측 버튼을 눌렀다면...
        // 1. firePos의 위치에서 수류탄을 생성한다.
        // 2. 전방 위쪽 45도 방향으로 물리적인 힘(Inpulse 타입)을 가한다.
        // - 수류탄 프리팹 변수: grenadePrefab
        // - 던지는 힘 변수: throwPower


    }
}
