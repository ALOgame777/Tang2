using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카메라 화면 바깥 일정한 위치에서 
// 혹은 플레이어와 일정한 위치 바깥에 위치 고정
// 시간 간격으로 몬스터를 소환
// 경과 시간 게임 플레이 시간이 지날 수록 많은 몬스터 혹은 강한 몬스터 스폰


public class MonsterFactory : MonoBehaviour
{

    public GameObject enemyPrefab;
    float playTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //시작 하고 시간이 지나면 시간이 지나면 몬스터를 생성함
        //일정 시간마다 CreateMonster 함수 실행

        playTime += Time.deltaTime;

    }

    void CreateMonster()
    {
       GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = transform.position;
    }
}
