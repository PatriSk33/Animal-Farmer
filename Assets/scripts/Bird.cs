/* 
    ------------------- PatriSk33 -------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Bird class inheriting from Animal
public class Bird : Animal
{
    public override void MakeSound()
    {
        Debug.Log("Tweet!");
    }

    public override void Move()
    {
        base.Move();
        Debug.Log(AnimalName + " is flying.");
    }
}