using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;

    public TextMeshProUGUI score;
    public TextMeshProUGUI best;

    private int bestFruits;
    private int fruits;

    public int Fruits
    {
        get { return fruits; }
        set
        {
            fruits = value;
            score.text = value.ToString();

            if(fruits > bestFruits)
            {
                bestFruits = fruits;
                PlayerPrefs.SetInt("best", bestFruits);
                PlayerPrefs.Save();
                best.text = $"best: {bestFruits}";
            }
        }
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        if (PlayerPrefs.HasKey("best"))
        {
            bestFruits = PlayerPrefs.GetInt("best");
            best.text = $"best: {bestFruits}";
        }
    }
}
