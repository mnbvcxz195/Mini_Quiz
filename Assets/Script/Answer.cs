using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public void AnswerCor()
    {
        if (isCorrect)
        {
            Debug.Log("????");
            quizManager.Correct();
        }
        else
        {
            Debug.Log("????");
            quizManager.Wrong();
        }
    }
}
