using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerManager : MonoBehaviour
{
    public ScoreSO score;
    public Image winner;

    // Start is called before the first frame update
    void Start()
    {
        winner.sprite = score.winner;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
