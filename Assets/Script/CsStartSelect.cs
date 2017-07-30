using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CsStartSelect : MonoBehaviour {
    private int pointerPos = 1;
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
                    changeYPos(-3.75f);
                    pointerPos = 3;
                    break;
                case 2:
                    changeYPos(0.75f);
                    pointerPos = 1;
                    break;
                case 3:
                    changeYPos(-1.55f);
                    pointerPos = 2;
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) //아래 키를 눌렀을 때
        {
            switch (pointerPos)
            {
                case 1:
                    changeYPos(-1.55f);
                    pointerPos = 2;
                    break;
                case 2:
                    changeYPos(-3.75f);
                    pointerPos = 3;
                    break;
                case 3:
                    changeYPos(0.75f);
                    pointerPos = 1;
                    break;
            }
        }

        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            switch (pointerPos)
            {
                case 1:
                    changeScene(1);
                    break;
                case 2:
                    changeScene(2);
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
        newPos.y = newYPos;
        this.transform.position = newPos;
    }

    void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
