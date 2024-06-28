using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�÷��̾ �Ѿ� �ٴѴ�.
//�÷��̾ ������ �÷��̾��� hp, ������ ���� ��Ų��.(�浹)
//�÷��̾��� ���⿡ ������ hp�� ���δ�.
//���� ���ݷ� 
//hp�� 0 �״´�
//������ ����ġ object�� ���� �߸���

//��ų ��Ÿ��

//���� ������ ���� �޴�������..
//BGM�� �ڽ��� ���� ����?
//�� �� BGM etc �ֱ�..
//ȭ��, ī�޶��� �ȷο� ���, Ÿ�ݰ� ȿ���� ���� ����Ʈ


public class EnemyMove : MonoBehaviour
{
    //Vector3 dir = new Vector3(1, 1, 0);
    public float enemySpeed = 15.0f;

    public Rigidbody2D target;

    bool isLive;

    Rigidbody2D rig;
    SpriteRenderer sp;

    public int hp = 30;
    public int expPoint;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //���� �ִϸ��̼� ������ ���ڴ�
        //���� ��� �ʿ��Ѱ�?
        //���� ������ ������?
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    void FixedUpdate()
    {
        Vector2 dirVec = target.position - rig.position;
        Vector2 nextVec = dirVec.normalized * enemySpeed * Time.fixedDeltaTime;
        rig.MovePosition(rig.position +  nextVec);
        rig.velocity = Vector2.zero;
    }

}
