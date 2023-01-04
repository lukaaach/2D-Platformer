using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatformersController : MonoBehaviour
{
    private bool jumpCheck;
    private bool activ;
    public GameObject CubePlatform1, CapsulePlatform2, CubePlatform3, CubePlatform4, CapsulePlatform5, CubePlatform6;
    public GameObject CubePlatform7, CubePlatform8, CapsulePlatform9, CubePlatform10;
    private PlayerMovement PlayerMovement;
    private Animator CubePlatform1Anim;
    private Animator CapsulePlatform2Anim;
    private Animator CubePlatform3Anim;
    private Animator CubePlatform4Anim;
    private Animator CapsulePlatform5Anim;
    private Animator CubePlatform6Anim;
    private Animator CubePlatform7Anim;
    private Animator CubePlatform8Anim;
    private Animator CapsulePlatform9Anim;
    private Animator CubePlatform10Anim;

    [SerializeField] private GameObject BgdCube1, BgdCube2, BgdCube3, BgdCube4, BgdCube5, BgdCube6, BgdCube7, BgdCube8, BgdCube9, BgdCube10, BgdCube11, BgdCube12;

    private void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
        CubePlatform1Anim = CubePlatform1.GetComponent<Animator>();
        CapsulePlatform2Anim = CapsulePlatform2.GetComponent<Animator>();
        CubePlatform3Anim = CubePlatform3.GetComponent<Animator>();
        CubePlatform4Anim = CubePlatform4.GetComponent<Animator>();
        CapsulePlatform5Anim = CapsulePlatform5.GetComponent<Animator>();
        CubePlatform6Anim = CubePlatform6.GetComponent<Animator>();
        CubePlatform7Anim = CubePlatform7.GetComponent<Animator>();
        CubePlatform8Anim = CubePlatform8.GetComponent<Animator>();
        CapsulePlatform9Anim = CapsulePlatform9.GetComponent<Animator>();
        CubePlatform10Anim = CubePlatform10.GetComponent<Animator>();
    }

    void Update()
    {
        platforms();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("JumpPlatformerTrigger"))
        {
            jumpCheck = true;
        }

        if (collision.gameObject.CompareTag("JumpPlatformerTrigger1")) 
        {
            BgdCube1.SetActive(true);
            BgdCube2.SetActive(true);
            BgdCube3.SetActive(true);
            BgdCube4.SetActive(true);
            BgdCube5.SetActive(true);
            BgdCube6.SetActive(true);
            BgdCube7.SetActive(true);
        }
        if (collision.gameObject.CompareTag("JumpPlatformerTrigger2"))
        {
            BgdCube8.SetActive(true);
            BgdCube9.SetActive(true);
            BgdCube10.SetActive(true);
            BgdCube11.SetActive(true);
            BgdCube12.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("JumpPlatformerExitTrigger"))
        {
            jumpCheck = false;
            BgdCube1.SetActive(false);
            BgdCube2.SetActive(false);
            BgdCube3.SetActive(false);
            BgdCube4.SetActive(false);
            BgdCube5.SetActive(false);
            BgdCube6.SetActive(false);
            BgdCube7.SetActive(false);
            BgdCube8.SetActive(false);
            BgdCube9.SetActive(false);
            BgdCube10.SetActive(false);
            BgdCube11.SetActive(false);
            BgdCube12.SetActive(false);
        }
    }

    private void platforms() 
    {
        if (Input.GetKeyDown(KeyCode.Space) & jumpCheck == true & PlayerMovement.isGrounded==true)
        {
            activ = !activ;
            if (activ == true)
            {
                CubePlatform1Anim.SetTrigger("idle");
                CapsulePlatform2Anim.SetTrigger("Work");
                CubePlatform3Anim.SetTrigger("idle");
                CubePlatform3.GetComponent<EdgeCollider2D>().isTrigger = false;
                CubePlatform4Anim.SetTrigger("idle");
                CapsulePlatform5Anim.SetTrigger("Work");
                CubePlatform6Anim.SetTrigger("work");
                CubePlatform6.GetComponent<EdgeCollider2D>().isTrigger = true;
                CubePlatform7Anim.SetTrigger("111");
                CubePlatform7.GetComponent<EdgeCollider2D>().isTrigger = false;
                CubePlatform8Anim.SetTrigger("JCP8S");
                CapsulePlatform9Anim.SetTrigger("JCP9D");
                CubePlatform10Anim.SetTrigger("JCP10Default");
                CubePlatform10.GetComponent<EdgeCollider2D>().isTrigger = false;
            }
            else 
            {
                CubePlatform1Anim.SetTrigger("work");
                CapsulePlatform2Anim.SetTrigger("Idle");
                CubePlatform3Anim.SetTrigger("work");
                CubePlatform3.GetComponent<EdgeCollider2D>().isTrigger = true;
                CubePlatform4Anim.SetTrigger("work");
                CapsulePlatform5Anim.SetTrigger("Idle");
                CubePlatform6Anim.SetTrigger("idle");
                CubePlatform6.GetComponent<EdgeCollider2D>().isTrigger = false;
                CubePlatform7Anim.SetTrigger("222");
                CubePlatform7.GetComponent<EdgeCollider2D>().isTrigger = true;
                CubePlatform8Anim.SetTrigger("JCP8D");
                CapsulePlatform9Anim.SetTrigger("JCP9S");
                CubePlatform10Anim.SetTrigger("JCP10Small");
                CubePlatform10.GetComponent<EdgeCollider2D>().isTrigger = true;
            }
        }
    }
}
