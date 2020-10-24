using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeverMoveOnCollisionFlip : MonoBehaviour
{
    public float speed = 1;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, 0);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
        Debug.Log("当たってる？");
    }
}
