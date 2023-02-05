using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class InputManager : MonoBehaviour
{
    public PlayerInput playerInput;
    public PlayerInputProvider playerInputProvider;

    void Awake()
    {
        var index = playerInput.playerIndex;
        playerInputProvider = PlayerInputProvider.inputproviders.FirstOrDefault(m => m.playerIndex == index);
        playerInputProvider.isActive = true;
    }

    public void AnswerRight(InputAction.CallbackContext context){
        if(playerInputProvider == null){
            return;
        }
        playerInputProvider.AnswerRight(context);
    }
    public void AnswerDown(InputAction.CallbackContext context){
        if(playerInputProvider == null){
            return;
        }
        playerInputProvider.AnswerDown(context);

    }
    public void AnswerLeft(InputAction.CallbackContext context){
        if(playerInputProvider == null){
            return;
        }
        playerInputProvider.AnswerLeft(context);

    }
    public void AnswerUp(InputAction.CallbackContext context){
        if(playerInputProvider == null){
            return;
        }
        playerInputProvider.AnswerUp(context);

    }
}
