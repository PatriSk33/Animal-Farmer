/* 
    ------------------- PatriSk33 -------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cat class inheriting from Animal
public class Cat : Animal   // INHERITANCE
{

    private void Start()
    {
        AnimalName = gameObject.name;
    }

    // POLYMORPHISM: overriding MakeSound method
    public override void MakeSound() // POLYMORPHISM
    {
        Debug.Log("Meow!");
    }

    // POLYMORPHISM: overriding Move method
    public override void Move() // POLYMORPHISM
    {
        base.Move();
        Debug.Log(AnimalName + " is sneaking.");
    }
}
