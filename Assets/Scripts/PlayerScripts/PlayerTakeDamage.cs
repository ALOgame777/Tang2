using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTakeDamage : MonoBehaviour
{
    public Image healthBar; // ������ �̹���
    public float maxHealth = 100f; // �÷��̾� �ִ� ü��
    public Image playerHP;
    private float currentHealth; //����ü��
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // �÷��̾��� ü���� �ʱ�ȭ
    }

    // Update is called once per frame
    void Update()
    {
    }

    
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        float fillAmount = currentHealth / maxHealth;
        healthBar.fillAmount = fillAmount;
        if(currentHealth <= 0)
        {
            Time.timeScale = 0f;
        }
    }    


}
