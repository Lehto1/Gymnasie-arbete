using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            RB.velocity = new Vector2(0, 2);
        }

        if (Input.GetKey(KeyCode.S))
        {
            RB.velocity = new Vector2(0, -2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            RB.velocity = new Vector2(-2, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            RB.velocity = new Vector2(2, 0);
        }
    }
}
