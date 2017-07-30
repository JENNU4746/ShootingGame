using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBullet : MonoBehaviour {
    private const float moveSpeed = 4f; //이동 속도를 상수로 지정
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveY = moveSpeed * Time.deltaTime; //이동 거리 지정
        transform.Translate(0, moveY, 0); //이동 반영
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("Enemy")) //부딪힌 객체가 적일 시
        {
            CsGameManager.instance.AddScore(50);
            Destroy(this.gameObject); //자신 삭제
        }
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject); //자기 자신 삭제
    }
}
