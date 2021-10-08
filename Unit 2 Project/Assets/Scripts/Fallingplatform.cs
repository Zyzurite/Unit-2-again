using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallingplatform : MonoBehaviour
{

    public bool Fake;
    bool touched = false;
    // Start is called before the first frame update
    public void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
        {
            if (Fake)
            {
                StartCoroutine("ColorChanger");
            }

            else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }

    }

    IEnumerator ColorChanger()
    {
        if (!touched)
        {
            touched = true;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            yield return new WaitForSeconds(.3f);
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            yield return new WaitForSeconds(.3f);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            yield return new WaitForSeconds(.3f);
            Deactivator();
        }

    }
        
    void Deactivator()
    {
        if (Fake)
        {
            touched = false;
            gameObject.SetActive(false);
        }
    }

}
