using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum QuizType
{
    Common = 0, 
    Non = 1
}

public class QuizSelect : MonoBehaviour
{
    public Button[] quizSelect = null;    

    private void Start()
    {
        for (int i = 0; i < quizSelect.Length; i++)
        {
            QuizType type = (QuizType)i;
            quizSelect[i].onClick.AddListener(()=> {
                Select(type);
            });
        }
    }

    public void Select(QuizType quizType)
    {
        if(quizType == QuizType.Common)
        {
            gameObject.SetActive(false);
            Debug.Log(quizType);
        }

        if(quizType == QuizType.Non)
        {
            gameObject.SetActive(false);
            Debug.Log(quizType);
        }
    }
}
