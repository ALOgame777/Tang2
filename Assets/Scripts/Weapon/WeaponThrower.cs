using UnityEngine;
using System.Linq;

public class WeaponThrower : MonoBehaviour
{
    public GameObject weaponPrefab; // ���� ������
    public float throwForce = 5f; // ������ ��
    public float detectionRadius = 15f; // �� ���� ����
    public float throwInterval = 2f; // ���� ������ ���� (��)
    public float weaponLifetime = 2f; // ���Ⱑ �����ϴ� �ð� (��)
    public float offsetAngle = 90f; // ���� �̹��� ������ ���� (12�� ������ 0���� ��)
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
            // ���� �������� �ν��Ͻ�ȭ�մϴ�
            GameObject weapon = Instantiate(weaponPrefab, transform.position, Quaternion.identity);
            // Rigidbody2D ������Ʈ�� �����ɴϴ�
            Rigidbody2D rb = weapon.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // �� ���������� ���͸� ����մϴ�
                Vector2 directionToEnemy = ((Vector2)nearestEnemy.transform.position - (Vector2)transform.position).normalized;
                Debug.Log("Throwing weapon towards: " + directionToEnemy);
                // ���⿡ ���� ���մϴ�
                rb.AddForce(directionToEnemy * throwForce, ForceMode2D.Impulse);

                // ���⸦ �̵� �������� ȸ����ŵ�ϴ�
                float angle = Mathf.Atan2(directionToEnemy.y, directionToEnemy.x) * Mathf.Rad2Deg;
                weapon.transform.rotation = Quaternion.Euler(0, 0, angle - offsetAngle);

                // weaponLifetime �Ŀ� ���⸦ �����մϴ�
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
        // ������ �ݰ� ���� ��� ���� ã���ϴ� (2D �ݶ��̴� ���)
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRadius);
        return colliders
            .Where(c => c.CompareTag("Enemy"))
            .OrderBy(c => Vector2.Distance(transform.position, c.transform.position))
            .Select(c => c.gameObject)
            .FirstOrDefault();
    }
}