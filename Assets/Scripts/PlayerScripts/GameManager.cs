using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ �����ϸ� ���� �ð� �� ���Ͱ� ����, ������
//���� �Ͻ�����
//���� ����� ȭ�� �̵�(����ȭ��, �����, ��Ϻ���)

//������ ����/ ����ġ/ ����
//�÷��̾� ������ �� ������ ���� â 
//�÷��̾ ���ڸ� ȹ���ϸ� ���, ��ų ���� â

//���� �÷��� �ð��� ������ ���� ����


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerMove player;
    int playerExp;
    int playerLv;
    string[] playerEqu;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
