using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAreaManager : MonoBehaviour
{
    private PlayerInfo playerInfo;
    public GameObject player0;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    // Start is called before the first frame update
    void Start()
    {
        playerInfo = FindObjectOfType<PlayerInfo>();

        //for (var i = player0.transform.childCount - 1; i >= 0; i--)
        //{
        //    Object.Destroy(player0.transform.GetChild(i).gameObject);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
