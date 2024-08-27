using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;


    public int number;


    public void IncreaseScore()
    {
        int number = Random.Range(5, 11);
        
        score += number;
        PlayerPrefs.SetInt("Score ", score);
    }

    public void Count()
    {
        Debug.Log("score Up:" + (score-number) );
    }

   
    private void Awake()
    {
        Load();
        number = score;
    }

    public void A()
    {
        score = number;
          Debug.Log("score Up:" + (score-number) );
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
    }
    public void Save()
    {
        PlayerPrefs.Save();
    }
}
