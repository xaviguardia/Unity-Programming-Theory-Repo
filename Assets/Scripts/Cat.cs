using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Dog : Animal
{
    public Vector3 jumpDistance = new Vector3(0, 1, 0);
    private AudioSource sound;
    
    public void Start()
    {
        sound = GetComponent<AudioSource>();
        // will fail
        this.animalName = "My name is Catty";
        // will work
        this.animalName = "catty";
    }
    public override void Jump()
    {
        Debug.Log("called Jump on Dog");
        Move(jumpDistance);
    }
    public override void Sound()
    {
        Debug.Log("playing sound in dog");
        sound.Play();
    }
}
