using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    StartOfRound,
    StartOfCategory,
    StartOfQuestion,
    Answering,
    AnswerChecking,
    EndOfCategory,
    EndGame

}
public class GameAreaManager : MonoBehaviour
{
    private PlayerInfo playerInfo;
    public GameObject player0;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    public GameState gameState;

    public float timeToAnswerQuestion;
    public float currentTimer;
    public int questionsInCategory = 5;
    public int currentquestionsInCategory = 0;

    public QuestionManager questionManager;

    // Start is called before the first frame update
    void Start()
    {
        QuestionParser.Init();
        gameState = GameState.StartOfRound;
    }
    [ContextMenu("ResetQuestion")]
    public void StartOfCategoryTest() {
        gameState = GameState.StartOfCategory;
    }

    public void Update(){
        switch (gameState) {
            case GameState.StartOfRound:
                break;
            case GameState.StartOfCategory:
                StartOfCategory();
                break;
            case GameState.StartOfQuestion:
                if(currentquestionsInCategory >= questionsInCategory){
                    gameState = GameState.EndOfCategory;
                }
                StartOfQuestionRound();
                break;
            case GameState.Answering:
                WaitingAnswers();
                break;
            case GameState.AnswerChecking:
                AnswerChecking();
                break;
            case GameState.EndOfCategory:
                gameState = GameState.StartOfCategory;
                break;
            case GameState.EndGame:
                break;
        }
    }
    public void StartOfCategory(){
        var retval = questionManager.SetCategory();
        gameState = retval ? GameState.StartOfQuestion : GameState.EndGame;
    }

    public void StartOfQuestionRound(){
        questionManager.ResetQuestion();
        var stillquestions = questionManager.CreateQuestions();
        gameState = stillquestions ? GameState.Answering: GameState.StartOfCategory;

    }
    public void WaitingAnswers(){
        foreach(var input in PlayerInputProvider.inputproviders){
            if(input.isActive && !input.answeredQuestion){
                return;
            }
        }
        gameState = GameState.AnswerChecking;
    }
    public void AnswerChecking(){
        foreach(var input in PlayerInputProvider.inputproviders){
            input.CheckAnswer();
        }
        currentquestionsInCategory++;
        gameState = GameState.StartOfQuestion;
    }
}
