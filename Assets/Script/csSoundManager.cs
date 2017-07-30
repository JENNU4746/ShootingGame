using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSoundManager : MonoBehaviour {
    public AudioClip soundExplosion, soundBullet; //재생할 소리를 변수로 담음
    AudioSource myAudio; //AudioSource 컴포넌트를 변수로 담음
    public static csSoundManager instance; //자신을 변수로 담음

    //Start보다 먼저 실행됨, 활성화<->비활성화 영향 받지 않고 객체 생성시 최초 1회만 호출
    void Awake()
    {
        if(csSoundManager.instance==null) //instance가 비어있는지 검사
        {
            csSoundManager.instance = this; //자기 자신을 담음
        }
    }

	// Use this for initialization
	void Start () {
        myAudio = this.gameObject.GetComponent<AudioSource>(); //AudioSource 오브젝트를 변수로 담음
	}

    public void Playsound(int index)
    {
        switch (index)
        {
            case 0:
                myAudio.PlayOneShot(soundExplosion);
                break;
            case 1:
                myAudio.PlayOneShot(soundBullet);
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
