using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppad : MonoBehaviour
{
    public GameObject player;
    public Vector3 direction;
    Vector3 Direction;

    public float jumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Direction = transform.TransformDirection(direction * jumpForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            player = collision.gameObject;
            //apply force to the Player's rigidbody to let him "jump"
            player.GetComponent<Rigidbody>().AddForce(Direction, ForceMode.Impulse);
        }
    }
}
