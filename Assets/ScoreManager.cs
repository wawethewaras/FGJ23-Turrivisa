using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    private int health = 4;
    public int playerIndex;

    public PlayerInfo playerInfo;

    public List<GameObject> characters;

    private int characterIndex;

    public void Start()
    {
        characterIndex = playerInfo.GetCharacter(playerIndex);

        for (int i = characters.Count - 1; i >= 0; i--)
        {
            if (i != characterIndex)
            {
                GameObject.Destroy(characters[i]);
                characters.RemoveAt(i);
            }
        }
    }

    public void TakeHealth()
    {
        Debug.Log("Kutsuu TakeHealth funktiota");



        GameObject child = characters[0];
        Animator animator = child.GetComponent<Animator>();

        animator.SetInteger("TeethLeft", health);

        health--;

        animator.SetInteger("Health", health);

        Debug.Log("Animatorin integer arvo: " + animator.GetInteger("Health"));
    }
}
