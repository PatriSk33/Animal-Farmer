/* 
    ------------------- PatriSk33 -------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cat class inheriting from Animal
public class Cat : Animal
{

    private void Start()
    {
        AnimalName = gameObject.name;
    }

    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }

    public override void Move()
    {
        base.Move();
        Debug.Log(AnimalName + " is sneaking.");
    }
}
