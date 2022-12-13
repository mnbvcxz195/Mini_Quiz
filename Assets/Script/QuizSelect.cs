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
    public GameObject obj;
    public Button[] quizSelect = null;
    public int Q_Type;

    #region Singletone
    public static QuizSelect instance = null;

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

    private void Start()
    {
        for (int i = 0; i < quizSelect.Length; i++)
        {
            QuizType type = (QuizType)i;
            quizSelect[i].onClick.AddListener(() => {
                Select(type);
            });
        }
    }

    public int Select(QuizType quizType)
    {
        if(quizType == QuizType.Common)
        {
            gameObject.SetActive(false);
            obj.SetActive(true);
            Q_Type = 0;
            Debug.Log(quizType);
        }

        if(quizType == QuizType.Non)
        {
            gameObject.SetActive(false);
            obj.SetActive(true);
            Q_Type = 1;
            Debug.Log(quizType);
        }

       QuizManager.instance.MakeQuestion();

        return Q_Type;
    }

}
