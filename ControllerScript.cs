using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerScript : MonoBehaviour
{

    public UnityEvent upEvent;
    public UnityEvent downEvent;

    public void OnMouseDown()
    {
        Debug.Log("Down");
        downEvent?.Invoke();
    }
    public void OnMouseUp()
    {
        Debug.Log("Up");
        upEvent?.Invoke();

    }
}
