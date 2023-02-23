using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   public GameObject thePlatform;
   public Transform generationPoint;
   public float distanceBetween;
   private float platformWidth;
   public int sayi;
  

   private void Start() {
    platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.y;
   }
   public void Update() {
    for (int i = 0; i < 1; i++)
    {
        sayi = Random.Range(-2, 2);
    }
    if (transform.position.y < generationPoint.position.y)
    {
        transform.position = new Vector3(sayi,transform.position.y+platformWidth+distanceBetween,0);
        Instantiate(thePlatform,transform.position,transform.rotation);
    }
   }

}
