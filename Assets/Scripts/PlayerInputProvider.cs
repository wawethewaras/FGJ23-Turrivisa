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
    public bool answeredQuestion;
    public ScoreManager scoreManager;

    public void Start(){
        scoreManager = GetComponent<ScoreManager>();
        inputproviders.Add(this);
    }
    public void Reset(){
        answeredQuestion = false;
    }
    public void AnswerRight(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
            var retval = QuestionManager.AnswerQuestion(AnswerSet.RIGHT);
            if(retval){
                scoreManager.score++;
            }
            else {
                scoreManager.health++;
            }
        }
    }
    public void AnswerDown(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
            var retval = QuestionManager.AnswerQuestion(AnswerSet.DOWN);
            if(retval){
                scoreManager.score++;
            }
            else {
                scoreManager.health++;
            }
        }
    }
    public void AnswerLeft(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
            var retval = QuestionManager.AnswerQuestion(AnswerSet.LEFT);
            if(retval){
                scoreManager.score++;
            }            
            else {
                scoreManager.health++;
            }
        }
    }
    public void AnswerUp(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed && !answeredQuestion) {
           var retval =  QuestionManager.AnswerQuestion(AnswerSet.UP);
            if(retval){
                scoreManager.score++;
            }
            else {
                scoreManager.health++;
            }
        }
    }
}