using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
[System.Serializable]
public class CurrentQuestion {
    public string currentQuestion;
    public string aAnswer; //A is always correct
    public string bAnswer;
    public string cAnswer;
    public string dAnswer;
    public string category;

}

public class QuestionManager : MonoBehaviour
{
    public CurrentQuestion currentQuestion;

    static List<string> currentQuestions = new List<string>();
    public static int correctAnswerIndex = 0;

    [ContextMenu("CreateQuestions")]
    public void CreateQuestions(){
        currentQuestions.Clear();
        currentQuestions.Add(currentQuestion.aAnswer);
        currentQuestions.Add(currentQuestion.bAnswer);
        currentQuestions.Add(currentQuestion.cAnswer);
        currentQuestions.Add(currentQuestion.dAnswer);
        currentQuestions = currentQuestions.OrderBy(a => Guid.NewGuid()).ToList();
        for(int i = 0; i < currentQuestions.Count; i++){
            if(currentQuestions[i] == currentQuestion.aAnswer){
                correctAnswerIndex = i;
                break;
            }
        }
    }

    //0 Up, 1 Right, 2 Down, 3 Left
    public static bool AnswerQuestion(AnswerSet answerIndex){
        if((int)answerIndex == correctAnswerIndex){
            return true;
        }
        return false;
    }
    [ContextMenu("ResetQuestion")]
    public void ResetQuestion() {
        foreach(var input in PlayerInputProvider.inputproviders){
            input.Reset();

        }
    }
}
