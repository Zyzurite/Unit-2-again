using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera followCamera;


    public void Start()
    {
        followCamera.enabled = true;
    }

    public void Update()
    {
        
    }
}