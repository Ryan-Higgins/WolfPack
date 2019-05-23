using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public static GameObject player;


    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Wolf");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, gameObject.transform.position.y,
            player.transform.position.z);

    }
}
