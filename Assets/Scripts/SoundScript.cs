using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    [SerializeField] EnemyMovement EnemyMove;
    [SerializeField] GameObject EnemyPosition;
    // Start is called before the first frame update
    void Start()
    {
        float Distance = Vector2.Distance(EnemyPosition.transform.position, transform.position);
        if (Distance <= 7)
        {
            EnemyMove.Status = 3;
            EnemyMove.ObjectOfInterest = gameObject;
        }
    }
}
