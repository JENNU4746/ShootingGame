using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CsCredit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.KeypadEnter))
        {
            Debug.Log("ENTER!");
            changeScene(0);
        }
	}

    void changeScene(int scene)
    {
        Debug.Log("HEY!");
        SceneManager.LoadScene(scene);
    }
}
