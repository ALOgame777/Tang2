using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ī�޶� ȭ�� �ٱ� ������ ��ġ���� 
// Ȥ�� �÷��̾�� ������ ��ġ �ٱ��� ��ġ ����
// �ð� �������� ���͸� ��ȯ
// ��� �ð� ���� �÷��� �ð��� ���� ���� ���� ���� Ȥ�� ���� ���� ����


public class MonsterFactory : MonoBehaviour
{

    public GameObject enemyPrefab;
    float playTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���� �ϰ� �ð��� ������ �ð��� ������ ���͸� ������
        //���� �ð����� CreateMonster �Լ� ����

        playTime += Time.deltaTime;

    }

    void CreateMonster()
    {
       GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = transform.position;
    }
}
