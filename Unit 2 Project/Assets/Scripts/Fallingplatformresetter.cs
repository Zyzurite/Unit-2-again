using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallingplatformresetter : MonoBehaviour
{
    public GameObject warpPoint;
    public GameObject platforms ;
    // Start is called before the first frame update

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            for (int i = 0; i < platforms.transform.childCount; i++)
            {
                platforms.transform.GetChild(i).gameObject.SetActive(true);
                platforms.transform.GetChild(i).GetComponentInChildren<Renderer>().material.color = Color.white;
            }

            collision.gameObject.transform.position = warpPoint.transform.position;

        }
    }
}
