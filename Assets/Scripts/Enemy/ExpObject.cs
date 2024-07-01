using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//몬스터가 죽으면 몬스터의 경험치 포인터가 담긴 경험치 오브젝트가 떨어짐
//캐릭터가 근처에 접근하면 흡수 됨
//플레이어에게 닿으면 사라지면서 경험치 포인터를 플레이어에게 전달
// 게임 매니져 UI에 표시




public class ExpObject : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    float moveSpeed = 5.0f;
    public int exp = 10;

    int playerExp;

    int playerLevel = 1;
    string[] playerEqu;

    



    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        //몬스터가 죽으면 그자리에 생성 제자리에 있어라
        //gameObject.transform.position = enemy.transform.position;
        //뿅 하고 생기는 애니메이션?


    }

    // Update is called once per frame
    void Update()
    {

        // 만약 플레이어가 땡기는 위치에 있다면 플레이어 쪽으로 이동
        dir = player.transform.position - transform.position;
        dir.Normalize();
        transform.position += dir * moveSpeed * Time.deltaTime;


        //(살짝 멀어졌다가 빨려 들어가는 느낌의 이동)

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            //ScoreManager 을 가져온다

            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManager sm = smObject.GetComponent<ScoreManager>();
            sm.currentScore += exp;

            sm.currentScoreUI.text = "현재 점수 : " + sm.currentScore;

        //플레이어와 부딪히면 경험치 상승
            print($"{exp}의 경험치를 획득 했다!");
            print(sm.currentScore);
        Destroy(gameObject);
        }
    }
    
}
