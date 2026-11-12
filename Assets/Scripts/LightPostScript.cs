using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightPostScript : MonoBehaviour
{
    [SerializeField] GameObject EvenIfBroken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EvenIfBroken.SetActive(true);
        EvenIfBroken.transform.position = new Vector2(transform.position.x - 0.879f, transform.position.y + 0.04f);
        Destroy(gameObject);
    }
}
