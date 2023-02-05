using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInfo", menuName = "ScriptableObjects/PlayerInfo", order = 1)]
public class PlayerInfo : ScriptableObject
{

    public int playerCharacter0;
    public int playerCharacter1;
    public int playerCharacter2;
    public int playerCharacter3;

    public void SetPlayerCharacter(int playerIndex, int characterIndex)
    {
        switch (playerIndex)
        {
            case 0:
                playerCharacter0 = characterIndex;
                    break;
            case 1:
                playerCharacter1 = characterIndex;
                break;
            case 2:
                playerCharacter2 = characterIndex;
                break;
            case 3:
                playerCharacter3 = characterIndex;
                break;
        }
    }

    public int GetCharacter(int index)
    {
        switch (index)
        {
            case 0:
                return playerCharacter0; 
            case 1:
                return playerCharacter1;
            case 2:
                return playerCharacter2;
            case 3:
                return playerCharacter3;
        }

        return 4;
    }
}
