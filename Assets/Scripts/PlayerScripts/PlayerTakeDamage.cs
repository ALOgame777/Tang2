using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTakeDamage : MonoBehaviour
{
    public Image healthBar; // 게이지 이미지
    public float maxHealth = 100f; // 플레이어 최대 체력
    public Image playerHP;
    private float currentHealth; //현재체력
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // 플레이어의 체력을 초기화
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
