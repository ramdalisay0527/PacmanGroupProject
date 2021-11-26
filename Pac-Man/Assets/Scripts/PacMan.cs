using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float speed = 8;
    public float speedMulti = 1;
    public Vector2 movement;
    public GameObject[] teleportPoints;
    GameObject leftSide;
    GameObject rightSide;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        leftSide = teleportPoints[0];
        rightSide = teleportPoints[1];
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement(rigid);
       

    }
    private void FixedUpdate()
    {



    }
    private void playerMovement(Rigidbody2D controller)
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        controller.MovePosition(controller.position + movement* speed *Time.fixedDeltaTime);
 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == leftSide.name)
        {
            gameObject.transform.position = new Vector3(rightSide.transform.position.x - 1, rightSide.transform.position.y,transform.position.z);
            
        }
        if (collision.gameObject.name == rightSide.name)
        {
            gameObject.transform.position = new Vector3(leftSide.transform.position.x + 1, leftSide.transform.position.y, transform.position.z);

        }
    }
}
