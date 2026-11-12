using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] GameObject DeathObject;
    [SerializeField] GameObject EnemyPosition;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector2.Distance(EnemyPosition.transform.position, transform.position);
        if (Distance <= 0.3f)
        {
            StartCoroutine(FlowerMan());
        }
    }

    IEnumerator FlowerMan()
    {
        DeathObject.SetActive(true);
        DeathObject.transform.position = new Vector2(transform.position.x, transform.position.y - 0.41f);
        transform.position = new Vector2(2, 100);

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver");
    }
}
