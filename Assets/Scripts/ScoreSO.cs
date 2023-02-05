using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreSO", menuName = "ScriptableObjects/ScoreSO", order = 1)]
public class ScoreSO : ScriptableObject
{
    public Sprite winner;
    public List<Sprite> characters = new List<Sprite>();
    public PlayerInfo playerino;

    public void setWinner(){
        var players = PlayerInputProvider.inputproviders;
        var theplayer = PlayerInputProvider.inputproviders[0];
        foreach(var player in players){
            if(player.scoreManager.score > theplayer.scoreManager.score){
                theplayer = player;
            }
        }

        winner = characters[playerino.GetCharacter(theplayer.playerIndex)];
    }
}
