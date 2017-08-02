using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsGameOver : MonoBehaviour
{
    public int pointerPos = 1;
    public GameObject startGame;
    public GameObject inGame;
    public GameObject gameOver;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //위 키를 눌렀을 때
        {
            switch (pointerPos)
            {
                case 1:
                    changeYPos(-2.96f);
                    pointerPos = 2;
                    break;
                case 2:
                    changeYPos(2.96f);
                    pointerPos = 1;
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //아래 키를 눌렀을 때
        {
            switch (pointerPos)
            {
                case 1:
                    changeYPos(-2.96f);
                    pointerPos = 2;
                    break;
                case 2:
                    changeYPos(2.96f);
                    pointerPos = 1;
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (pointerPos)
            {
                case 1:
                    startGame.SetActive(true);
                    gameOver.SetActive(false);
                    break;
                case 2:
                    inGame.SetActive(true);
                    gameOver.SetActive(false);
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
