using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Data
{
    private int health;
    private string name;

    public Data(int health, string name) 
    {
        this.health = health;
        this.name = name;
    }
}
public class Stats : MonoBehaviour
{
    public int attack = 5;
    Data data = new Data(100, "Do");

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("attack º¯¼ö : " + attack);
    }

}
