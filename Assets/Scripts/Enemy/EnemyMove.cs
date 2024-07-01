using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float enemySpeed = 15.0f;
    private Transform target;
    bool isLive = true;
    Rigidbody2D rig;
    SpriteRenderer sp;
    public int hp = 30;
    public int expPoint;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        // �÷��̾ ã�� Ÿ������ ����
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
        else
        {
            Debug.LogError("Player not found!");
        }
    }

    void Update()
    {
        if (!isLive || target == null)
            return;

        // �÷��̾� �������� ��������Ʈ ������
        if (target.position.x > transform.position.x)
        {
            sp.flipX = true;
        }
        else
        {
            sp.flipX = false;
        }
    }

    void FixedUpdate()
    {
        if (!isLive || target == null)
            return;

        Vector2 dirVec = (Vector2)target.position - rig.position;
        Vector2 nextVec = dirVec.normalized * enemySpeed * Time.fixedDeltaTime;
        rig.MovePosition(rig.position + nextVec);
        rig.velocity = Vector2.zero;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isLive = false;
        // ���⿡ ����ġ ������Ʈ�� �����ϴ� �ڵ带 �߰��� �� �ֽ��ϴ�.
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // �÷��̾�� �������� �ִ� ����
            //PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            //if (playerHealth != null)
            //{
               // playerHealth.TakeDamage(10); // ���� ������ ��
            //}
        }
    }
}