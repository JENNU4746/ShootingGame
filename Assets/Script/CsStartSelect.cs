using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsStartSelect : MonoBehaviour {
    public int pointerPos = 1;
    public GameObject startGame;
    public GameObject Credit;
    public GameObject inGame;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow)) //위 키를 눌렀을 때
        {
            switch (pointerPos)
            {
                case 1:
                    changeYPos(-4.46f);
                    pointerPos = 3;
                    break;
                case 2:
                    changeYPos(2.23f);
                    pointerPos = 1;
                    break;
                case 3:
                    changeYPos(2.23f);
                    pointerPos = 2;
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //아래 키를 눌렀을 때
        {
            switch (pointerPos)
            {
                case 1:
                    changeYPos(-2.23f);
                    pointerPos = 2;
                    break;
                case 2:
                    changeYPos(-2.23f);
                    pointerPos = 3;
                    break;
                case 3:
                    changeYPos(4.46f);
                    pointerPos = 1;
                    break;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            switch (pointerPos)
            {
                case 1:
                    inGame.SetActive(true);
                    startGame.SetActive(false);
                    break;
                case 2:
                    Credit.SetActive(true);
                    startGame.SetActive(false);
                    break;
                case 3:
                    Application.Quit();
                    break;
            }
        }
    }

    void changeYPos(float newYPos)
    {
        Vector2 newPos; //좌표 변환을 위한 임시변수
        newPos = this.transform.position;
        newPos.y += newYPos;
        this.transform.position = newPos;
    }
}
