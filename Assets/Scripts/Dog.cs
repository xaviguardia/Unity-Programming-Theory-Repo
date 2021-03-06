using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Cat : Animal
{
    public Vector3 jumpDistance = new Vector3(0, 2, 0);
    private AudioSource sound;
    public void Start()
    {
        sound = GetComponent<AudioSource>();
      
    }
    public override void Jump()
    {
        Debug.Log("called Jump on Cat");
        Move(jumpDistance);
    }
    public override void Sound()
    {
        Debug.Log("playing sound in cat");
        sound.Play();
    }
}
