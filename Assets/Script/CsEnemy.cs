using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsEnemy : MonoBehaviour {
    public const float moveSpeed = 1.3f; //상수로 움직일 속도를 지정
    public GameObject explosionPrefab; //폭발 Prefab
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveControl(); //프레임이 변화할 때마다 움직임을 관리하는 함수 호출
	}

    void moveControl()
    {
        float distanceY = Time.deltaTime * moveSpeed; //움직일 거리 계산
        this.gameObject.transform.Translate(0, -1*distanceY, 0); //움직임 반영
    }

    //rigidBody가 무언가와 충돌할 때 호출되는 함수
    //Collider2D other롤 부딛힌 객체 받아옴
    void OnTriggerEnter2D()
    {
        //Instantiate는 객체를 하나 생성(복제)함 
        Instantiate(explosionPrefab, //생성할 객체의 원본
            this.transform.position, //생성될 위치. this.transform.position은 자기 자신의 위치
            Quaternion.identity); //객체 회전값. Quaternion.identity는 회전이 적용되지 않은 값
        Destroy(this.gameObject); //자신 파괴
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject); //자기 자신 삭제
    }
}
