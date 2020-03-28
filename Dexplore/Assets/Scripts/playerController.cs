using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Vector2 playerPos = transform.position;
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerPos.x += moveSpeed * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerPos.x -= moveSpeed * Time.deltaTime;
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerPos.y += moveSpeed * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerPos.y -= moveSpeed * Time.deltaTime;
        }
        transform.position = playerPos;
    }
}
