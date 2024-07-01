using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���Ͱ� ������ ������ ����ġ �����Ͱ� ��� ����ġ ������Ʈ�� ������
//ĳ���Ͱ� ��ó�� �����ϸ� ��� ��
//�÷��̾�� ������ ������鼭 ����ġ �����͸� �÷��̾�� ����
// ���� �Ŵ��� UI�� ǥ��




public class ExpObject : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    float moveSpeed = 10.0f;
    

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        //���Ͱ� ������ ���ڸ��� ���� ���ڸ��� �־��
        //gameObject.transform.position = enemy.transform.position;
        //�� �ϰ� ����� �ִϸ��̼�?
    }

    // Update is called once per frame
    void Update()
    {

        // ���� �÷��̾ ����� ��ġ�� �ִٸ� �÷��̾� ������ �̵�
        dir = player.transform.position - transform.position;
        transform.position += dir * moveSpeed * Time.deltaTime;

        //(��¦ �־����ٰ� ���� ���� ������ �̵�)

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
        //�÷��̾�� �ε����� ����ġ ���
        print("����ġ�� ��� �Ͽ���!");
        //�׸��� �������
        Destroy(gameObject);
        }
    }

}
