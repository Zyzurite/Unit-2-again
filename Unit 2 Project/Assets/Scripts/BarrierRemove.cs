using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierRemove : MonoBehaviour
{
    public GameObject barriers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < barriers.transform.childCount; i++)
            {
                barriers.transform.GetChild(i).gameObject.SetActive(false);
            }

            this.gameObject.SetActive(false);
        }
    }
}
