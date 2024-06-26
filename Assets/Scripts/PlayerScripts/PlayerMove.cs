using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    Vector2 inputVec;
    Rigidbody2D rb;
    SpriteRenderer sp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + nextVec);
    }

    private void LateUpdate()
    {
        if(inputVec.x != 0)
        {
            sp.flipX = inputVec.x > 0;
        }
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

}
