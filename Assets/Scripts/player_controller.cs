using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
   
    public float speed;
    public float increaseSpeed;
    private Rigidbody2D rb;

    private Vector3 movement;
    private float actualInc;
    private bool spdUp = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        actualInc = speed * increaseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Dash();

        {
            if (spdUp == false)
            {
                float h = Input.GetAxisRaw("HorizontalP1");
                float v = Input.GetAxisRaw("VerticalP1");

                Vector3 movement = new Vector3(h, 0, v);
                rb.AddForce(movement * speed);
            }

            if (spdUp == true)
            {
                float h = Input.GetAxisRaw("HorizontalP1");
                float v = Input.GetAxisRaw("VerticalP1");

                Vector3 movement = new Vector3(h, 0, v);
                rb.AddForce(movement * actualInc);
            }
        }
    }


    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        float moveX = x * speed;
        float moveY = y * speed;

        rb.velocity = new Vector2(moveX, moveY);
    }

    void Dash()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Click");
            player_controller speedPlayer = GameObject.Find("Player").GetComponent<player_controller>();
            SpeedUp();

        }

        //void onTriggerEnter(Collider other)
        //{
        //    player_controller speedPlayer = GameObject.Find("Player").GetComponent<player_controller>();
         //   speedPlayer.SpeedUp();
        //}

        void SpeedUp()
        {
            speed = increaseSpeed + speed;
        }
    }
}
