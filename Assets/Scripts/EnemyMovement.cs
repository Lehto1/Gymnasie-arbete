using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject[] Checkpoints = new GameObject[5];
    int Value = 0;
    [SerializeField] float Speed;
    public GameObject ObjectOfInterest;

    // 1 = Patrolling
    // 2 = Attacking
    // 3 = Investigating sound
    public int Status = 1;

    // Update is called once per frame
    void Update()
    {
        if (Status == 1)
        {
            SettingPosition();
        }
        else if (Status == 3)
        {
            Investigating();
        }
    }

    void SettingPosition()
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

    void Investigating()
    {
        transform.position = Vector2.MoveTowards(transform.position, ObjectOfInterest.transform.position, Speed * Time.deltaTime);

        if (transform.position.x < ObjectOfInterest.transform.position.x + 0.3f && transform.position.x > ObjectOfInterest.transform.position.x - 0.3f && transform.position.y < ObjectOfInterest.transform.position.y + 0.3f && transform.position.y > ObjectOfInterest.transform.position.y - 0.3f)
        {
            Status = 1;
        }
    }
}
