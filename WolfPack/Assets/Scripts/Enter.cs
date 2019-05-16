using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public static bool inDen;
    public static GameObject wolf;
    public GameObject inv;
    
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Wolf") && !inDen)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                wolf = other.gameObject;
                other.gameObject.SetActive(false);
                inv.SetActive(true);
                StartCoroutine(Delay());
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.2f);
        inDen = true;
    }
}
