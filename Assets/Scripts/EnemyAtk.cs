using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//접촉하면 자동으로 데미지가들어가는 구조..
//그런데 특수기가 하나, 둘 있으면 재밌긴 할 것 같음(보스는 2개 보통은 0-1개)

public class EnemyAtk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //쿨타임 돈다~
    }

    // Update is called once per frame
    void Update()
    {
        //쿨타임이 다 돌면 특수기 시전
        //특정 조건이면 특수기 시전(hp가 얼마 이하)
        //당연히 쿨타임도 있고 쿨타임이 다 차있어야 시전 가능
        
    }
}
