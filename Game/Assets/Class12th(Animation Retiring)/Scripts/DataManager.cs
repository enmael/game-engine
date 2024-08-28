using System;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;

    public int number;

    [SerializeField] ScoreUI scoreUI;
    public void IncreaseScore()
    {
       //int number = Random.Range(5, 11);

        score += number;

        scoreUI.OnUpdate(number);
        PlayerPrefs.SetInt("Score ", score);
    }

    //public void Count()
    //{
    //    Debug.Log("score Up:" + (score-number) );
    //}

   
    private void Awake()
    {
        Load();
        //number = score;
    }

    //public void A()
    //{
    //    score = number;
    //      Debug.Log("score Up:" + (score-number) );
    //}

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
    }
    public void Save()
    {
        PlayerPrefs.Save();
    }
    #region ∞≠ªÁ¥‘ «Æ¿Ã

    public void Initialozed()
    {
        

        PlayerPrefs.DeleteAll();
        Load(); 
    }

    #endregion
}
