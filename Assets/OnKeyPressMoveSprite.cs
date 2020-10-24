using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPressMoveSprite : MonoBehaviour
{

    public float speed = 2;
    
    float vx = 0;
    float vy = 0;
    bool leftFlag = false;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0;

        if (Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }

        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;
        }

        if (Input.GetKey("up"))
        {
            vy = speed;
        }

        if (Input.GetKey("down"))
        {
            vy = -speed;
        }
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;

    }
}
