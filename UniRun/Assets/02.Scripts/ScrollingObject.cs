using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 오브젝트를 지속적으로 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f;   // 이동 속도

    // 동일한 메서드 이름으로 각기 다른 기능 구현 -> 오버로딩
    void Update()
    {
        // 초당 speed의 속도로 왼쪽으로 평행이동(Translate가 함) 구현
        transform.Translate(Vector3.left * speed * Time.deltaTime);   // == new Vector(-1,0,0)

        
    }
}
