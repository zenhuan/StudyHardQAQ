using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public BoxCollider2D col;
    public float input_x ;
    public bool input_y;
    public int speed = 10;
    public float jumpforce = 1f;
    public bool isground;
    
    void Start()
    {
        

    }

    public void Update()
    {
        GetInput();
        Move();
        Jump();
        Ray();
    }

    public void Move()
    {
        rb.velocity = new Vector2(input_x * speed , rb.velocity.y);

    }

    public void Jump()
    {
        if(isground && input_y)
        {
            rb.AddForce(Vector2.up* 200 * jumpforce);
        }

    }

    public void Ray()
    {
        //取得此碰撞器底部位置的信息
        Vector3 origin = col.bounds.center + new Vector3(0, -col.bounds.extents.y);
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, 0.1f , 1 << 3);
        
        if(hit.collider != null )
        {
            isground = true;
        }
        else
        {
            isground = false;
        }
    }

    public void GetInput()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetKeyDown(KeyCode.Space);
    }


}


