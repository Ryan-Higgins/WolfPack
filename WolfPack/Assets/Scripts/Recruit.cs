using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recruit : MonoBehaviour
{
 private Pack myPack;
 
 void Start()
 {
  myPack = GetComponent<Pack>();
 }
 
 void OnTriggerStay(Collider other)
 {
  if (other.CompareTag("Wolf"))
  {
   if (Input.GetKeyUp(KeyCode.E))
   {
    print("Worked");
    myPack.partOfPack = true;
   }
  }
 }
}
