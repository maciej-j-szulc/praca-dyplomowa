using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue;
    Text scoreText;

    private void Start()
    {
        scoreValue = 0;
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = ": " + scoreValue.ToString();
    }
}
