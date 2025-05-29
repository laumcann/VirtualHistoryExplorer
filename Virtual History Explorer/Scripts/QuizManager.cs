using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


/* Set up a Quiz UI, with a question and an answer panel.*/
public class QuizManager : MonoBehaviour
{

    public AudioSource audioRight;

    public AudioSource audioWrong;
    // Set up variables 

    public GameObject answerOne;

    public GameObject answerTwo;

    public GameObject answerThree;

    public GameObject answerCorrect;

    public GameObject wellDone;

    public GameObject tryAgain;
    
    public GameObject allCorrect;

    public AudioSource congrats;

    public GameObject questionOne;

    public GameObject questionTwo;

    public GameObject questionThree;

    public GameObject quizTable;

    public GameObject quizTableTwo;

    // Start is called before the first frame update
    void Start()
    {

        tryAgain.SetActive(false);
        wellDone.SetActive(false);
        
    }

    public void ChooseAnswerOne() 

    {
        audioWrong.Play();
        tryAgain.SetActive(true);
        answerOne.SetActive(false);
        //SceneManager.LoadSceneAsync(1);

    }

    public void ChooseAnswerTwo()

    {

        audioWrong.Play();
        tryAgain.SetActive(true);
        answerTwo.SetActive(false);
        //SceneManager.LoadSceneAsync(1);

    }

    public void ChooseAnswerThree()

    {

        audioWrong.Play();
        tryAgain.SetActive(true);
        answerThree.SetActive(false);
        //SceneManager.LoadSceneAsync(1);

    }

    public void ChooseAnswerCorrectQuestionOne()

    {

        audioRight.Play();
        tryAgain.SetActive(false);
        wellDone.SetActive(true);
        wellDone.SetActive(false);
        congrats.Play();
        quizTable.SetActive(true);

        //allCorrect.SetActive(true);

    }

    
    public void ChooseAnswerCorrectQuestionTwo()

    {

        audioRight.Play();
        tryAgain.SetActive(false);
        wellDone.SetActive(true);
        wellDone.SetActive(false);
        congrats.Play();
        quizTableTwo.SetActive(true);

        //allCorrect.SetActive(true);

    }

    
    public void ChooseAnswerCorrectQuestionThree()

    {

        audioRight.Play();
        tryAgain.SetActive(false);
        wellDone.SetActive(true);
        wellDone.SetActive(false);
        congrats.Play();

        //allCorrect.SetActive(true);

    }
}
