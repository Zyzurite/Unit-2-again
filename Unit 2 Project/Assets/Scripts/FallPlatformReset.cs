using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatformReset : MonoBehaviour
{
    public Vector3 position;
    public GameObject platforms;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < platforms.transform.childCount; i++)
            {
                Vector3 resetposition = platforms.transform.GetChild(i).GetComponent<FallPlatform>().start;
                Vector3 rotateposition = platforms.transform.GetChild(i).GetComponent<FallPlatform>().rotation;
                platforms.transform.GetChild(i).gameObject.transform.position = resetposition;
                platforms.transform.GetChild(i).gameObject.transform.eulerAngles = new Vector3(0,0,0);
                platforms.transform.GetChild(i).gameObject.SetActive(true);
                platforms.transform.GetChild(i).gameObject.GetComponentInChildren<Rigidbody>().useGravity = false;
                platforms.transform.GetChild(i).gameObject.GetComponentInChildren<Rigidbody>().isKinematic = true;
            }

            collision.gameObject.transform.position = position;
        }

        if (collision.gameObject.CompareTag("Faller")) //applies only to objects tagged with “Player”
        {
            collision.gameObject.SetActive(false);
        }

        
    }
}
