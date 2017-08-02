using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsSpawnManager : MonoBehaviour {
    public bool enableSpawn = true;
    public GameObject Enemy; //적 Prefab 저장
    private float timePassed=0; //난이도 조절을 위한 시간 측정

    void SpawnEnemy()
    {
        float randomX = Random.Range(-2.65f, 2.65f); //적이 나타날 X좌표를 랜덤으로 생성
        if(enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector2(randomX, 4.5f), Quaternion.identity); //랜덤한 x, 화면 제일 위에서 Enemy 하나 생성
        }
    }

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 3, 1-(timePassed/100)); //3초 후부터 SpawnEnemy함수를 1-(timePassed/100)초마다 반복 실행
	}

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 50)
        {
            timePassed = 50;
        }
    }
}
