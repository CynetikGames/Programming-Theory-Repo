using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField animalName;
    public Cat cat;
    public Dog dog;
    public TMP_Text resultText;

    void Start()
    {

        animalName.onEndEdit.AddListener(AnimalEntered);
    }

    public void AnimalEntered(string animalNameInput)
    {
        //if (animalNameInput.ToLower() == "cat") // Case-insensitive match
        //{
            ShowAnimal(animalNameInput);
        //}
    }

    public void ShowAnimal(string animalInput)
    {
        if (animalInput.ToLower() == "cat")
        {
            resultText.text = cat.ShowInfo(); // Call ShowInfo to show the info
        }
        else if (animalInput.ToLower() == "dog")
        {

            resultText.text = dog.ShowInfo(); // Call ShowInfo to show the info
        }
        else
        {
            resultText.text = "Please enter \"cat\" or \"dog\" for animal name";
            Debug.Log("Please enter \"cat\" or \"dog\" for animal name");
        }


    }
}
