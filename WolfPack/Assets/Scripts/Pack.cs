using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pack : MonoBehaviour
{
    public GameObject Den;
    public bool partOfPack;


    void Update()
    {
        if (partOfPack)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, Den.transform.position, 1 * Time.deltaTime);
            transform.LookAt(Den.transform.position);
        }
    }
}
