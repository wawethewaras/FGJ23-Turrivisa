using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class UIManager : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_Text aButton;
    public TMP_Text bButton;
    public TMP_Text cButton;
    public TMP_Text dButton;

    public int SetQuestionText(CurrentQuestion currentQuestion){
        var currentQuestions = new List<string>();

        questionText.text  = currentQuestion.currentQuestion;
        currentQuestions.Add(currentQuestion.aAnswer);
        currentQuestions.Add(currentQuestion.bAnswer);
        currentQuestions.Add(currentQuestion.cAnswer);
        currentQuestions.Add(currentQuestion.dAnswer);
        currentQuestions = currentQuestions.OrderBy(a => Guid.NewGuid()).ToList();


        aButton.text  = currentQuestions[0];
        bButton.text  = currentQuestions[1];
        cButton.text  = currentQuestions[2];
        dButton.text  = currentQuestions[3];
        for(int i = 0; i < currentQuestions.Count; i++){
            if(currentQuestions[i] == currentQuestion.aAnswer){
                return i;
            }
        }
        return 0;

    }
    public void ResetQuestions(){

    }
}
