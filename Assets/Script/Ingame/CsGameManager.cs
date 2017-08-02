using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CsGameManager : MonoBehaviour {
    public static CsGameManager instance; //어디서나 접근할 수 있도록 static으로 자기 자신 저장할 변수 생성
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아옴
    private int score = 0;

    void Awake()
    {
        if(!instance) //정적으로 자신 체크
        {
            instance = this; //정적으로 자신 저장
        }
    }

    public void AddScore(int num) //점수 추가 함수
    {
        score += num; //점수를 더해줌
        scoreText.text = "Score: " + score; //텍스트에 반영
    }

	// Use this for initialization
	void Start () {
        scoreText.text = "Score: " + score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
