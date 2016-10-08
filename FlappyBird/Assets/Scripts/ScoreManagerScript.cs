﻿using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

    public static int Score { get; set; }

	
	void Start () {
        (Tens.gameObject as GameObject).SetActive(false);
        (Hundreds.gameObject as GameObject).SetActive(false);
	}
	
	// aktualizowanie  wyniku  co  1  klatkę
	void Update () {

        if (previousScore != Score) ////zapamiętaj  wynik   gdy  wynik  0
        { 
            if(Score < 10)
            {
                //just draw units
                Units.sprite = numberSprites[Score];
            }
            else if(Score >= 10 && Score < 100)
            {
                (Tens.gameObject as GameObject).SetActive(true);
                Tens.sprite = numberSprites[Score / 10];
                Units.sprite = numberSprites[Score % 10];
            }
            else if(Score >= 100)
            {
                (Hundreds.gameObject as GameObject).SetActive(true);
                Hundreds.sprite = numberSprites[Score / 100];
                int rest = Score % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
        }

	}


    int previousScore = -1;
    public Sprite[] numberSprites;
    public SpriteRenderer Units, Tens, Hundreds;
}
