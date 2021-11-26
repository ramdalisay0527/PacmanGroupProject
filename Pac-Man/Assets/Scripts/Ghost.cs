using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GhostNode node;
    public float speed = 8;
    float speedMulti = 1;
    Rigidbody2D rigid;
    public Vector2 movingDirect;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        //rigid.velocity = startingDirect;
        
    }
    private void FixedUpdate()
    {
        //rigid.MovePosition(rigid.position + newDirection() * speed *Time.fixedDeltaTime);
        movement();
    }
    void movement()
    {
        //rigid.velocity = newDirection();
        transform.position = newDirection(movingDirect);
    }
 
    Vector3 newDirection(Vector2 direct)
    {
        return new Vector3(transform.position.x + direct.x * Time.fixedDeltaTime * speedMulti, transform.position.y + direct.y * Time.fixedDeltaTime * speedMulti,transform.position.z);
    }
    public void updateDirect(Vector2 newDirect)
    {
        movingDirect = newDirect;
    }
}
