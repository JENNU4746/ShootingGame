using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsEnemy : MonoBehaviour {
    public const float moveSpeed = 1.3f; //상수로 움직일 속도를 지정
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
}
