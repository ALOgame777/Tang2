using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�÷��̾ �Ѿ� �ٴѴ�.
//���� ���� ������ �� ����ġ �ʴ´�.

//�÷��̾ ������ �÷��̾��� hp, ������ ���� ��Ų��.(�浹)
//�÷��̾��� ���⿡ ������ hp�� ���δ�.
//���� ���ݷ� 
//hp�� 0 �״´�
//������ ����ġ object�� ���� �߸���

//��ų ��Ÿ��

//���� ������ ȭ�� �ٱ� ���丮���� ����

//BGM�� �ڽ��� ���� ����?
//�� �� BGM etc �ֱ�..
//ȭ��, ī�޶��� �ȷο� ���, Ÿ�ݰ� ȿ���� ���� ����Ʈ


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
            Destroy(gameObject);

        }



    }

    //�浹 ����� ������ ����
    //1. �÷��̾� >> �÷��̾��� ü�� ����߸���
    //2. �÷��̾��� ����(����) >> hp ����
    //3. ���� ���� ��ġ�� ��ȭx ���� �������� ����


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            print("�÷��̾�� ���ظ� ���!");
        }
        //�÷��̾�� �ε����� �÷��̾� hp ����
        //Ȥ�� ����(���� ����)

        
    }
    
}


