using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera CMvcam1;
    [SerializeField] private CinemachineVirtualCamera CMvcam2;
    [SerializeField] private CinemachineVirtualCamera CMvcam3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CameraTrigger1")) 
        {
            CMvcam1.Priority = 5;
            CMvcam2.Priority = 10;
            CMvcam3.Priority = 5;
        }
        if (collision.gameObject.CompareTag("JumpPlatformerTrigger"))
        {
            CMvcam1.Priority = 5;
            CMvcam2.Priority = 5;
            CMvcam3.Priority = 10;
        }
        if (collision.gameObject.CompareTag("CameraTrigger2"))
        {
            CMvcam1.Priority = 10;
            CMvcam2.Priority = 5;
            CMvcam3.Priority = 5;
        }
    }
}
