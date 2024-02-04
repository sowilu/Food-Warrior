using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public TextMeshProUGUI score;
    public TextMeshProUGUI best;

    private int fruits = 0;
    private int bestFruits = 0;



    public int Fruits
    {
        get { return fruits; }
        set
        {
            fruits = value;
            score.text = fruits.ToString();

            if(fruits > bestFruits)
            {
                bestFruits = fruits;
                best.text = $"best: {bestFruits}";

                PlayerPrefs.SetInt("best", bestFruits);
                PlayerPrefs.Save();
            }
        }
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        if (PlayerPrefs.HasKey("best"))
        {
            bestFruits = PlayerPrefs.GetInt("best");
            best.text = $"best: {bestFruits}";
        }
    }
}
