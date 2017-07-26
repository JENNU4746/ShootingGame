using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPlayer : MonoBehaviour
{
    public const float moveSpeed = 5.0f; //움직이는 속도 정의
                                         // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveControl(); //캐릭터를 움직이는 함수를 프레임마다 호출
    }

    void moveControl()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //Axes를 통하여 키의 방향 판단, 속도와 프레임 판정을 곱하여 이동량 결정
        this.gameObject.transform.Translate(distanceX, 0, 0); //이동량만큼 실제로 이동 반영
    }

    //rigidBody가 무언가와 충돌할 때 호출되는 함수
    //Collider2D other롤 부딛힌 객체 받아옴
    void OnTriggerEnter2D(Collider2D other)
    {
        //부딪힌 객체의 태그를 비교하여 적인지 판단
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(other.gameObject); //적 파괴
            Destroy(this.gameObject); //자신 파괴
        }
    }
}