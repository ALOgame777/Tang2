using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어를 쫓아 다닌다.
//플레이어에 닿으면 플레이어의 hp, 생명을 종료 시킨다.(충돌)
//플레이어의 무기에 닿으면 hp가 깍인다.
//무기 공격력 
//hp가 0 죽는다
//죽으면 경험치 object를 떨어 뜨린다

//스킬 쿨타임

//몹의 생성은 게임 메니져에서..
//BGM은 박스를 따로 만들어서?
//맵 에 BGM etc 넣기..
//화면, 카메라의 팔로우 방식, 타격감 효과에 맞춰 이펙트


public class EnemyMove : MonoBehaviour
{
    Vector3 dir = new Vector3(1, 1, 0);
    public float enemySpeed = 15.0f;

    public GameObject player;

    public int hp = 30;
    public int expPoint;
    
    
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




        
    }
    
}
