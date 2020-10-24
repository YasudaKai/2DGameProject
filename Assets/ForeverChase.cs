using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeverChase : MonoBehaviour
{

    public string targetObjectName;
    public float speed = 1;

    GameObject targetObject;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        targetObject = GameObject.Find(targetObjectName);

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        float vx = dir.x * speed;
        float vy = dir.y * speed;

        rb.velocity = new Vector2(vx, vy);

        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }
}
