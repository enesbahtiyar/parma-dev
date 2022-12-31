using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] int score = 0;

    [SerializeField] Text scoreText;

    public static Counter Instance;

    private void Start()
    {
        Instance = this;
    }
    public void increaseScore()
    {
        score++;
        scoreText.text = scoreText.ToString();
    }
}
