using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class LastRecord : MonoBehaviour
{

    public Text displayScore;
    public Text displayLive;
    void Start()
    {

        displayScore.text = "Last play Score: " + ScoreSystem.theScore.ToString();

        displayLive.text = "Last PLay Live: " + ScoreSystem.CurrnetLive;
    }
}