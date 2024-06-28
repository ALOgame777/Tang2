using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPref;
    public float damage;
    public int per;

    public void Init(float damage, int per)
    {
        this.damage = damage;
        this.per = per;
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPref, transform.position, transform.rotation);
        }

    }
    private void FixedUpdate()
    {
        if (this.bulletPref != null)
        {
            if (this.bulletPref.GetComponent<Rigidbody>() != null)
            {
                this.bulletPref.SetActive(true);
            }
            
        }

    }

}
