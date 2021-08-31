using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Vector3 jumpDistance = new Vector3(0, 1, 0);
    public override void Jump()
    {
        Debug.Log("called Jump on Dog");
        Move(jumpDistance);
    }
}
