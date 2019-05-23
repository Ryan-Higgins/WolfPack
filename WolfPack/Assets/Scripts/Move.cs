using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    public static int speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        
        move *= speed * Time.deltaTime;
        rb.MovePosition(transform.position + move);
        transform.LookAt(transform.position + new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));

        if (Input.GetKey(KeyCode.P))
        { 
            print(Den.pack.Count);
            PlayerFollow.player = Den.pack[0];
            Den.pack[0].GetComponent<Move>().enabled = true;
            Den.pack[0].GetComponent<Attack>().enabled = true;
            Den.pack[0].GetComponent<Recruit>().enabled = false;
            Den.pack[0].GetComponent<Pack>().enabled = false;
            Den.pack.Remove(Den.pack[0]);
            gameObject.SetActive(false);
            print(Den.pack.Count);
        }
    }
}
