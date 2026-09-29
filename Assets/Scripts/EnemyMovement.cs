using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject[] Checkpoints = new GameObject[5];
    int Value = 0;
    [SerializeField] float Speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Value >= 5)
        {
            Value = 0;
        }

        transform.position = Vector2.MoveTowards(transform.position, Checkpoints[Value].transform.position, Speed * Time.deltaTime);

        if (transform.position.x < Checkpoints[Value].transform.position.x + 1 && transform.position.x > Checkpoints[Value].transform.position.x - 1 && transform.position.y < Checkpoints[Value].transform.position.y + 1 && transform.position.y > Checkpoints[Value].transform.position.y - 1)
        {
            Value += 1;
        }
    }
}
