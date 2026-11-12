using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] EnemyMovement EnemyMove;
    [SerializeField] GameObject Player;
    [SerializeField] float Speed;

    // Update is called once per frame
    void Update()
    {
        if (EnemyMove.Status == 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyMove.Status = 2;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        EnemyMove.Status = 1;
    }
}
