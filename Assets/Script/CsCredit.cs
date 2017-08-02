using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCredit : MonoBehaviour {
    public GameObject Credit;
    public GameObject startGame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            startGame.SetActive(true);
            Credit.SetActive(false);
        }
	}
}
