using UnityEngine;
using System.Linq;

public class WeaponThrower : MonoBehaviour
{
    public GameObject weaponPrefab; // 무기 프리팹
    public float throwForce = 5f; // 던지는 힘
    public float detectionRadius = 15f; // 적 감지 범위
    public float throwInterval = 2f; // 무기 던지는 간격 (초)
    public float weaponLifetime = 2f; // 무기가 존재하는 시간 (초)
    public float offsetAngle = 90f; // 무기 이미지 오프셋 각도 (12시 방향이 0도일 때)
    private float nextThrowTime;

    void Update()
    {
        if (Time.time >= nextThrowTime)
        {
            ThrowWeapon();
            nextThrowTime = Time.time + throwInterval;
        }
    }

    void ThrowWeapon()
    {
        GameObject nearestEnemy = FindNearestEnemy();
        if (nearestEnemy != null)
        {
            Debug.Log("Found nearest enemy: " + nearestEnemy.name);
            // 무기 프리팹을 인스턴스화합니다
            GameObject weapon = Instantiate(weaponPrefab, transform.position, Quaternion.identity);
            // Rigidbody2D 컴포넌트를 가져옵니다
            Rigidbody2D rb = weapon.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // 적 방향으로의 벡터를 계산합니다
                Vector2 directionToEnemy = ((Vector2)nearestEnemy.transform.position - (Vector2)transform.position).normalized;
                Debug.Log("Throwing weapon towards: " + directionToEnemy);
                // 무기에 힘을 가합니다
                rb.AddForce(directionToEnemy * throwForce, ForceMode2D.Impulse);

                // 무기를 이동 방향으로 회전시킵니다
                float angle = Mathf.Atan2(directionToEnemy.y, directionToEnemy.x) * Mathf.Rad2Deg;
                weapon.transform.rotation = Quaternion.Euler(0, 0, angle - offsetAngle);

                // weaponLifetime 후에 무기를 삭제합니다
                Destroy(weapon, weaponLifetime);
            }
            else
            {
                Debug.LogError("Weapon prefab does not have a Rigidbody2D component!");
            }
        }
        else
        {
            Debug.Log("No enemy found within detection radius.");
        }
    }

    GameObject FindNearestEnemy()
    {
        // 지정된 반경 내의 모든 적을 찾습니다 (2D 콜라이더 사용)
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRadius);
        return colliders
            .Where(c => c.CompareTag("Enemy"))
            .OrderBy(c => Vector2.Distance(transform.position, c.transform.position))
            .Select(c => c.gameObject)
            .FirstOrDefault();
    }
}