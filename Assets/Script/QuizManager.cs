using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QnA> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public QuizSelect quizType = null;

    public Text QuestionText;

    #region Singletone
    public static QuizManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

    }
    #endregion
    void Start()
    {
       // MakeQuestion();
    }

    public void MakeQuestion()
    {
        QuestionText.text = QnA[currentQuestion].Question;
        SetAnswers();

    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
              options[i].GetComponent<Answer>().isCorrect = false;
              options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

              if (QnA[currentQuestion].CorrectAnswer ==  i + 1)
              {
                  options[i].GetComponent<Answer>().isCorrect = true;
              }
                
        }

    }

    public void Correct()
    {
        QnA.RemoveAt(currentQuestion);
        MakeQuestion();
    }

    public void Wrong()
    {

    }

}
