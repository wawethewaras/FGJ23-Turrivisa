using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int health;
    public int playerIndex;

    public PlayerInfo playerInfo;

    public GameObject[] characters;

    private int characterIndex;

    public void Start()
    {
        playerInfo = FindObjectOfType<PlayerInfo>();

        characterIndex = playerInfo.GetCharacter(playerIndex);

        for (int i = 0; i < characters.Length; i++)
        {
            if (i != characterIndex)
            {
                GameObject.Destroy(characters[i]);
            }
        }
    }
}
