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
    Vector3 dir = new Vector3(1, 1, 0);
    public float enemySpeed = 15.0f;

    public GameObject player;

    int hp;
    int expPoint;
    
    
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
        dir = player.transform.position - transform.position;
        dir.Normalize();
        //�÷��̾��� ������ ã�� �̵��Ѵ�.
        //������ P = p0 + vt
        // A ���� - B ���� = B���� A�� �ٶ󺸴� ���� 
        // dir = A vector - B  vector
        
        transform.position += dir * enemySpeed * Time.deltaTime;




        if (hp < 0) //ü���� 0 ���Ϸ� ��������
        {
            //transform.position �ڸ��� ExpObject�� �����
            //�������. ����

        }



    }
}
