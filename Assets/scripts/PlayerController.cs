using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Canvas worldCanvas;
    public TMP_Text interactionText;

    void Update()
    {
        // Basic movement code
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithAnimal();
        }
    }

    void InteractWithAnimal()
    {
        Collider2D collider = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), 5f);
        if (collider != null)
        {
            Animal animal = collider.GetComponent<Animal>();
            if (animal != null)
            {
                animal.MakeSound(); // POLYMORPHISM

                interactionText.text = animal.AnimalName + " says: ";

                // Set text to display the sound
                if (animal is Dog) interactionText.text += "Woof!";
                if (animal is Cat) interactionText.text += "Meow!";
                if (animal is Bird) interactionText.text += "Tweet!";

                // Display text for a short duration
                StartCoroutine(ShowInteractionText());
            }
        }
    }

    IEnumerator ShowInteractionText()
    {
        worldCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        worldCanvas.gameObject.SetActive(false);
    }
}
