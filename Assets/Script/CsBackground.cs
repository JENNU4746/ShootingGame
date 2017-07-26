using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBackground : MonoBehaviour {
    public const float scrollSpeed = 0.5f; //스크롤할 속도를 상수로 지정
    private Material thisMaterial; //Quad의 Material 데이터를 받아올 객체 선언
	// Use this for initialization
	void Start () {
        thisMaterial = GetComponent<Renderer>().material; //현재 객체의 Component들을 참조하여 Renderer 컴포넌트의 Material 정보 받아옴
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 newOffset = thisMaterial.mainTextureOffset; //새롭게 지정해 줄 Offset 객체 선언
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime)); //Y부분의 현재 y값에 프레임 보정한 속도를 더해줌
        thisMaterial.mainTextureOffset = newOffset; //최종적으로 Offset값 지정
	}
}
