using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    public GameObject warpPoint;
    void OnCollisionEnter(Collision collision)
   {
        if (collision.gameObject.CompareTag("Faller")) //applies only to objects tagged with “Player”
        {
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = warpPoint.transform.position;
        }
   }

}
