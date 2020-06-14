using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    public Camera arCamera;

    private void Start()
    {
        arCamera = Camera.main;
    }
    private void OnEnable()
    {
        arCamera = Camera.main;
    }
    void Update()
    {
        //Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(arCamera.transform);
        //Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        //transform.LookAt(arCamera.transform, Vector3.down);
    }
}
