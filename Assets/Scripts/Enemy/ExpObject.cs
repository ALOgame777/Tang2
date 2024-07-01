using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//���Ͱ� ������ ������ ����ġ �����Ͱ� ��� ����ġ ������Ʈ�� ������
//ĳ���Ͱ� ��ó�� �����ϸ� ��� ��
//�÷��̾�� ������ ������鼭 ����ġ �����͸� �÷��̾�� ����
// ���� �Ŵ��� UI�� ǥ��




public class ExpObject : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    float moveSpeed = 5.0f;
    public int exp = 10;

    int playerExp;

    int playerLevel = 1;
    string[] playerEqu;

    



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
        dir.Normalize();
        transform.position += dir * moveSpeed * Time.deltaTime;


        //(��¦ �־����ٰ� ���� ���� ������ �̵�)

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            //ScoreManager �� �����´�

            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManager sm = smObject.GetComponent<ScoreManager>();
            sm.currentScore += exp;

            sm.currentScoreUI.text = "���� ���� : " + sm.currentScore;

        //�÷��̾�� �ε����� ����ġ ���
            print($"{exp}�� ����ġ�� ȹ�� �ߴ�!");
            print(sm.currentScore);
        Destroy(gameObject);
        }
    }
    
}
