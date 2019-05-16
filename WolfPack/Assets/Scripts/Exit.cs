using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject inv;
    void Update()
    {
        if (Enter.inDen && !Enter.wolf.activeInHierarchy)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                Enter.wolf.SetActive(true);
                Enter.inDen = false;
                inv.SetActive(false);
            }
        }
    }
}
