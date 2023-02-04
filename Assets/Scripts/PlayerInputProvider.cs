using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class PlayerInputProvider : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //playerInput = GetComponent<PlayerInput>();
        //int index = playerInput.playerIndex;
    }
    public void AnswerRight(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("RIGHT :");
        }
    }
    public void AnswerDown(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("DOWN :");
        }
    }
        public void AnswerLeft(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("LEFT :");
        }
    }
        public void AnswerUp(InputAction.CallbackContext context){
        if (context.phase == InputActionPhase.Performed) {
            Debug.Log("UP :");
        }
    }
}