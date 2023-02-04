using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class PlayerInputProvider : MonoBehaviour
{
    public static List<PlayerInputProvider> inputproviders = new List<PlayerInputProvider>();

    public int playerIndex;

    public void Start(){

        inputproviders.Add(this);
    }
    public void AnswerRight(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("RIGHT :" + playerIndex);
        }
    }
    public void AnswerDown(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("DOWN :"+ playerIndex);
        }
    }
    public void AnswerLeft(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("LEFT :"+ playerIndex);
        }
    }
    public void AnswerUp(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("UP :"+ playerIndex);
        }
    }
}