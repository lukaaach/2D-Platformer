using System.Collections;
using UnityEngine;

public class PlatformsController : MonoBehaviour
{
    [SerializeField] private GameObject Platform1, Platform2, Platform3;
    [SerializeField] private GameObject Platform4, Platform5, Platform6;
    private bool activ, activ2;

    void Start()
    {
        StartCoroutine(timer1());
        StartCoroutine(timer2());
    }

    private IEnumerator timer1()
    {
        while (true) 
        {
            yield return new WaitForSeconds(3);
            activ = !activ;
            Platform1.SetActive(activ);
            Platform2.SetActive(!activ);
            Platform3.SetActive(activ);
            
        }
    }

    private IEnumerator timer2()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            activ2 = !activ2;
            Platform4.SetActive(!activ2);
            Platform5.SetActive(activ2);
            Platform6.SetActive(!activ2);
        }
    }
}
