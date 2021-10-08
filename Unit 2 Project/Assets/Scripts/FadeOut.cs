using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public float fadeSpeed;
    bool touched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(touched)
        {
            Fadeout();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            touched = true;
            
        }
    }

    private void Fadeout()
    {
        Color objectColor = this.GetComponent<Renderer>().material.color;
        float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime * 2f);

        objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
        this.GetComponent<Renderer>().material.color = objectColor;

        if (objectColor.a <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
