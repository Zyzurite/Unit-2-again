using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    public Vector3 start;
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        start = this.transform.position;
        rotation = this.transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }

    }
}
