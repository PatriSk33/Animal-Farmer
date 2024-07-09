// Base Animal class
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string animalName; // ENCAPSULATION

    public float speed = 2f;

    // ENCAPSULATION: property to get and set the animal name
    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    // ABSTRACTION: abstract method to be implemented by derived classes
    public abstract void MakeSound(); // ABSTRACTION

    // ABSTRACTION: higher-level method that abstracts unnecessary details
    public virtual void Move() // ABSTRACTION
    {
        Vector2 direction = GetRandomDirection();
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // ABSTRACTION: higher-level method to generate a random direction
    protected Vector2 GetRandomDirection() // ABSTRACTION
    {
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}