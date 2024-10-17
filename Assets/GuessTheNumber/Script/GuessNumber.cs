using TMPro;
using UnityEngine;

public class GuessNumber : MonoBehaviour
{
    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        messageText.text = "Guess the number";
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
        {
            messageText.text = "Please enter a valid number stupid monkey !";
            numberInput.text = "";
            return;
        }
        if (int.TryParse(numberInput.text, out int PlayerNumber))
        {
            if (PlayerNumber == randomNumber)
            {
                messageText.text = "Victory";
            }
            else
                if (PlayerNumber < randomNumber)
            {
                messageText.text = "Le nombre choisis est plus grand";
            }
            else
                if (PlayerNumber > randomNumber)
            {
                messageText.text = "le nombre choisis est plus petit";
            }
            else
            {
                messageText.text = "Please enter a valid number stupid monkey !";
            }
            numberInput.text = "";
        }
    }

    public void ResetGame()
    {
        messageText.text = "Guess the number";
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
    }
}
