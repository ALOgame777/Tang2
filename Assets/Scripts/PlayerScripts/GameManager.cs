using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임이 시작하면 일정 시간 후 몬스터가 리젠, 스폰됨
//게임 일시정지
//게임 종료시 화면 이동(시작화면, 재시작, 기록보기)

//유저의 레벨/ 경험치/ 무기
//플레이어 레벨업 시 아이템 선택 창 
//플레이어가 상자를 획득하면 장비, 스킬 선택 창

//일정 플레이 시간이 지나면 보스 스폰


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerMove player;
    int playerExp;
    int playerLv;
    string[] playerEqu;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
