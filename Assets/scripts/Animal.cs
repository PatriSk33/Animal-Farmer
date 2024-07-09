/* 
    ------------------- PatriSk33 -------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base Animal class
public abstract class Animal : MonoBehaviour
{
    private string animalName;
    public float speed = 2f;

    // Encapsulation: property to get and set the animal name
    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    // Abstract method to be implemented by derived classes
    public abstract void MakeSound();

    public virtual void Move()
    {
        // Random movement logic
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
