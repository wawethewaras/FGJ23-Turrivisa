using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
    public enum AnswerSet {
        UP = 0,
        RIGHT = 1,
        DOWN = 2,
        LEFT = 3

    }
public class PlayerInputProvider : MonoBehaviour
{

    public static List<PlayerInputProvider> inputproviders = new List<PlayerInputProvider>();

    public int playerIndex;
    public bool isActive = false;
    public bool answeredQuestion = true;
    public ScoreManager scoreManager;
    public bool AnsweredCorrectly = false;
    public void Start(){
        scoreManager = GetComponent<ScoreManager>();
        inputproviders.Add(this);
    }
    public void Reset(){
        if(isActive){
            answeredQuestion = false;
        }
    }
    public void AnswerRight(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
            AnsweredCorrectly = QuestionManager.AnswerQuestion(AnswerSet.RIGHT);
            answeredQuestion = true;
        }
    }
    public void AnswerDown(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
            AnsweredCorrectly = QuestionManager.AnswerQuestion(AnswerSet.DOWN);
            answeredQuestion = true;
        }
    }
    public void AnswerLeft(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
            AnsweredCorrectly = QuestionManager.AnswerQuestion(AnswerSet.LEFT);
            answeredQuestion = true;
        }
    }
    public void AnswerUp(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
           AnsweredCorrectly =  QuestionManager.AnswerQuestion(AnswerSet.UP);

            answeredQuestion = true;
        }
    }

    public void CheckAnswer(){
        if(AnsweredCorrectly){
            scoreManager.score++;
        }
        else {
            scoreManager.health++;
        }
    }
}