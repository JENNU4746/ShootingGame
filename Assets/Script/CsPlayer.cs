using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CsPlayer : MonoBehaviour
{
    public const float moveSpeed = 5.0f; //움직이는 속도 정의

    public GameObject explosionPrefab; //폭발 Prefab

    public GameObject bulletPrefab; //총알 Prefab
    public bool canShoot = true; //총알 발사 가능한지 검사
    const float shootDelay = 0.5f; //레이저 쏘는 주기 결정
    float shootTimer = 0; //타이머

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveControl(); //캐릭터를 움직이는 함수를 프레임마다 호출
        ShootControl(); //발사 관리 함수 호출
    }

    void moveControl()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //Axes를 통하여 키의 방향 판단, 속도와 프레임 판정을 곱하여 이동량 결정
        this.gameObject.transform.Translate(distanceX, 0, 0); //이동량만큼 실제로 이동 반영
        if (gameObject.transform.position.x >= 2.65f)
        {
            Vector2 vector; //새 변수 생성
            vector = transform.position; //새 변수에 현재 위치 저장
            vector.x = 2.65f; //변경할 위치값 저장
            transform.position = vector; //현재 위치에 변수값 저장
        }
        else if (gameObject.transform.position.x <= -2.65f)
        {
            Vector2 vector; //새 변수 생성
            vector = transform.position; //새 변수에 현재 위치 저장
            vector.x = -2.65f; //변경할 위치값 저장
            transform.position = vector; //현재 위치에 변수값 저장
        }
    }

    //rigidBody가 무언가와 충돌할 때 호출되는 함수
    //Collider2D other롤 부딛힌 객체 받아옴
    void OnTriggerEnter2D(Collider2D other)
    {
        //부딪힌 객체의 태그를 비교하여 적인지 판단
        if (other.gameObject.tag.Equals("Enemy"))
        {
            //Instantiate는 객체를 하나 생성(복제)함 
            Instantiate(explosionPrefab, //생성할 객체의 원본
                this.transform.position, //생성될 위치. this.transform.position은 자기 자신의 위치
                Quaternion.identity); //객체 회전값. Quaternion.identity는 회전이 적용되지 않은 값
//            Destroy(other.gameObject); //적 파괴
            Destroy(this.gameObject); //자신 파괴
        }
    }

    //총알 발사를 관리하는 함수.
    void ShootControl()
    {
        if(canShoot)
        {
            if(shootTimer>shootDelay&&Input.GetKey(KeyCode.Space))
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity); //총알 생성
                csSoundManager.instance.Playsound(1); //발사 효과음 재생
                shootTimer = 0; //쿨타임 초기화
            }
            shootTimer += Time.deltaTime; //쿨타임 카운트
        }
    }

    void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}