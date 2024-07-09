/* 
    ------------------- PatriSk33 -------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dog class inheriting from Animal
public class Dog : Animal
{
    private void Start()
    {
        AnimalName = gameObject.name;
    }

    public override void MakeSound()
    {
        Debug.Log("Woof!");
    }

    public override void Move()
    {
        base.Move();
        Debug.Log(AnimalName + " is running.");
    }
}
