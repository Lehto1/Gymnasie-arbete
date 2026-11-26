using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class TimeIncrease : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextValue;
    [SerializeField] PlayerDeath IsDeadScript;
    float TimerValue = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsDeadScript.IsDead == false)
        {
            TimerValue += Time.deltaTime;
        }

        TextValue.text = "Time " + TimerValue.ToString("F0");
    }
}
