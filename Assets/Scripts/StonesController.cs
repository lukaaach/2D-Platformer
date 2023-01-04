using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesController : MonoBehaviour
{
    [SerializeField] private Animator leftStoneAnim;
    [SerializeField] private Animator RightStoneAnim;
    [SerializeField] private GameObject frontGround;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("StoneTriggerDown")) 
        {
            RightStoneAnim.SetTrigger("Down");
        }
        if (collision.gameObject.CompareTag("StoneTriggerUpDown"))
        {
            RightStoneAnim.SetTrigger("Up");
            leftStoneAnim.SetTrigger("Down");
        }
        if (collision.gameObject.CompareTag("StoneTriggerUp"))
        {
            leftStoneAnim.SetTrigger("Up");
        }
        if (collision.gameObject.CompareTag("FrontGroundTrigger")) 
        {
            frontGround.SetActive(false);
        }
    }

}
