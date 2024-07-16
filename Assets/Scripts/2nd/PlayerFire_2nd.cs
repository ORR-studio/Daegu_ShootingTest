using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire_2nd : MonoBehaviour
{
    // 사용자가 마우스 좌측 버튼을 클릭하면 총알 프리팹을 씬에 생성하고 싶다.
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
