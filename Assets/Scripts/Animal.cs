using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
   [SerializeField]
   private Vector3 Distance = new Vector3(1,0,0);

    // keep the original position so we can reset
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            transform.position = originalPosition;
        }
    }
    // Abstraction Move the object the amount indicated in step distance
    public void Move(Vector3 distance)
    {
        transform.Translate(transform.position + distance);
        Debug.Log("Move invoked on Animal class");
    }
    public void ShowMessage(string message)
    {
        Debug.Log("from animal, the message:" + message);
    }

    public void OnMouseOver()
    {
        if(Input.GetMouseButton(0)) { 
            Debug.Log("MouseDown occurred in animal with left button pressed");
            Jump();
        } else if (Input.GetMouseButton(1))
        {
            Debug.Log("MouseDown occurred in animal with right button pressed");
            Sound();
        }


    }
    public virtual void Jump() {
        // This method can be overrided in child class
        Move(Distance);
    }

    public virtual void Sound()
    {
        ShowMessage("Animal emited a sound");
    }
    
}
