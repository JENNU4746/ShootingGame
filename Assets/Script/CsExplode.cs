using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsExplode : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 0.8f); //객체가 생성된 지 0.8초 후에 이 객체 삭제
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
