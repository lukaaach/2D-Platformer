using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    private SliderJoint2D sl;
    [SerializeField] private float Force;

    private void Awake()
    {
        sl = GetComponent<SliderJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ElevatorRightTrigger"))
        {
            StartCoroutine(timerRight());
        }
        if (collision.gameObject.CompareTag("ElevatorLeftTrigger"))
        {
            StartCoroutine(timerLeft());
        }
    }

    private IEnumerator timerRight()
    {
        yield return new WaitForSeconds(1);
        var mtr = sl.motor;
        mtr.motorSpeed = Force;
        sl.motor = mtr;
    }

    private IEnumerator timerLeft()
    {
        yield return new WaitForSeconds(1);
        var mtr = sl.motor;
        mtr.motorSpeed = -Force;
        sl.motor = mtr;
    }
}
