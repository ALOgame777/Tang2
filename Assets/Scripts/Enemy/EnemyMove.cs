using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어를 쫓아 다닌다.
//몬스터 끼리 움직일 때 겹지치 않는다.

//플레이어에 닿으면 플레이어의 hp, 생명을 종료 시킨다.(충돌)
//플레이어의 무기에 닿으면 hp가 깍인다.
//무기 공격력 
//hp가 0 죽는다
//죽으면 경험치 object를 떨어 뜨린다

//스킬 쿨타임

//몬스터 생성은 화면 바깥 팩토리에서 생성

//BGM은 박스를 따로 만들어서?
//맵 에 BGM etc 넣기..
//화면, 카메라의 팔로우 방식, 타격감 효과에 맞춰 이펙트


public class EnemyMove : MonoBehaviour
{
    Vector3 dir;
    public float enemySpeed = 15.0f;

    public GameObject player;

    int hp;
    int expPoint;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //등장 애니메이션 있으면 좋겠다
        //공격 모션 필요한가?
        //보스 몹에만 넣을까?
        
    }

    // Update is called once per frame
    void Update()
    {
        dir = player.transform.position - transform.position;
        dir.Normalize();
        //플레이어의 방향을 찾고 이동한다.
        //움직임 P = p0 + vt
        // A 벡터 - B 벡터 = B에서 A를 바라보는 벡터 
        // dir = A vector - B  vector
        
        transform.position += dir * enemySpeed * Time.deltaTime;




        if (hp < 0) //체력이 0 이하로 떨어지면
        {
            //transform.position 자리에 ExpObject를 남기고
            
            //사라져라. 죽음
            Destroy(gameObject);

        }



    }

    //충돌 대상의 종류와 반응
    //1. 플레이어 >> 플레이어의 체력 떨어뜨리기
    //2. 플레이어의 무기(공격) >> hp 닳음
    //3. 몹들 끼리 수치적 변화x 서로 겹쳐지지 않음


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            print("플레이어에게 피해를 줬다!");
        }
        //플레이어와 부딪히면 플레이어 hp 깍임
        //혹은 죽임(게임 오버)

        
    }
    
}


