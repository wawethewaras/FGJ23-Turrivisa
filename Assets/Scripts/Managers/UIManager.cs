using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_Text aButton;
    public TMP_Text bButton;
    public TMP_Text cButton;
    public TMP_Text dButton;

    public void SetQuestionText(CurrentQuestion currentQuestion){
        questionText.text  = currentQuestion.currentQuestion;
        aButton.text  = currentQuestion.aAnswer;
        bButton.text  = currentQuestion.bAnswer;
        cButton.text  = currentQuestion.cAnswer;
        dButton.text  = currentQuestion.dAnswer;

    }
    public void ResetQuestions(){
        
    }
}
