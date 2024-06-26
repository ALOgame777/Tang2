using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//몬스터가 죽으면 몬스터의 경험치 포인터가 담긴 경험치 오브젝트가 떨어짐
//캐릭터가 근처에 접근하면 흡수 됨
//플레이어에게 닿으면 사라지면서 경험치 포인터를 플레이어에게 전달
// 게임 매니져 UI에 표시

public class ExpObject : MonoBehaviour
{

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        //제자리에 있어라
        //뿅 하고 생기는 애니메이션?
    }

    // Update is called once per frame
    void Update()
    {

        // 만약 플레이어가 땡기는 위치에 있다면 플레이어 쪽으로 이동
        // 충돌? 하면 경험치 상승
    }
}
