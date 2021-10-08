using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBarrier : MonoBehaviour
{
    public GameObject Barrier;
    public float WaitTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        Barrier.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            Invoke("SetActive", WaitTime);
        }
        
    }

    void SetActive()
    {
        Barrier.SetActive(true);
    }
}

