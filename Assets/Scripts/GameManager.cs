using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject[] questions;
    public GameObject nextButton;
    public TextMeshProUGUI numberOfDollarsText;
    public static int questionIndex, numberOfDollars;
    public static int personality;
    public int[] dollarsToPay;

    // Start is called before the first frame update
    void Start()
    {
        questionIndex = 0;
        numberOfDollars = 0;
        personality = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextQuestion(bool willDo)
    {
        AudioManager.ButtonSound();
        if (questionIndex < questions.Length-1)
        {
            questions[questionIndex].SetActive(false);
            if (willDo)
            {
                numberOfDollars += dollarsToPay[questionIndex];
                numberOfDollarsText.text = numberOfDollars.ToString();
            }
            questionIndex++;
            questions[questionIndex].SetActive(true);
        }
        else
        {
            if (questionIndex < questions.Length &&willDo)
            {
                numberOfDollars += dollarsToPay[questionIndex];
                numberOfDollarsText.text = numberOfDollars.ToString();
                questionIndex++;
            }
            nextButton.SetActive(true);
            if (numberOfDollars<250)
            {
                personality = 0;
            }
            else if(numberOfDollars<1000)
            {
                personality = 1;
            }
            else{
                personality = 2;
            }
        }
    }
    public void NextClicked()
    {
        AudioManager.ButtonSound();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
