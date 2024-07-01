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
        // 플레이어를 찾아 타겟으로 설정
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

        // 플레이어 방향으로 스프라이트 뒤집기
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
        // 여기에 경험치 오브젝트를 생성하는 코드를 추가할 수 있습니다.
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어에게 데미지를 주는 로직
            //PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            //if (playerHealth != null)
            //{
               // playerHealth.TakeDamage(10); // 예시 데미지 값
            //}
        }
    }
}