using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    int lv = 1;
    int exp = 0;
    bool onChangeInfo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( onChangeInfo )
        {
        print("level : " + lv);
        print("exp : " + exp);
            onChangeInfo = false;
        }

    }
}
