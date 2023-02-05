using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using TMPro;

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
    public TMP_Text scoreText;
    public CharacterSelector characterSelector;
    public float delay = 0.1f;
    public float counter = 0f;
    public float currentMoveInputX = 0;

    public void Awake(){
        scoreManager = GetComponent<ScoreManager>();
        if(scoreText != null){
            scoreText.text = "0";
        }

        inputproviders.Add(this);
    }
    public void Update(){
        if(counter > 0){
            counter -= Time.deltaTime;
        }
        if(counter > 0 || Mathf.Abs(currentMoveInputX) < 0.5f){
            return;
        }
        counter = delay;

        if(currentMoveInputX > 0.7f) {
            characterSelector.ChangeCharacterBackward();
        }
        if(currentMoveInputX < -0.7f) {
            characterSelector.ChangeCharacterForward();
        }
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


    public void SelectCharacter(Vector2 direction){
        if(direction.x > 0.7f) {
            currentMoveInputX = 1;
        }
        else if(direction.x < -0.7f) {
            currentMoveInputX = -1;
        }
        else {
            currentMoveInputX = 0;
        }
    }
    public void CheckAnswer(){
        if(AnsweredCorrectly){
            scoreManager.score += 100;
        }
        else {
            scoreManager.health--;
        }
        scoreText.text = "" + scoreManager.score;
    }
}