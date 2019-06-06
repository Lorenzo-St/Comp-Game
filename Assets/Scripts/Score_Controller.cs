using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Score_Controller : MonoBehaviour
{

    [SerializeField] 
    private Game_manager GM;
    
    public string highScore;
    private String _directory;
    
    string fileName = "HighScore.txt";
    string fullPath;

    public int HigherScore;
    void Start()
    {
        fullPath = Path.GetFullPath(fileName);
        Debug.LogFormat("GetFullPath('{0}') returns '{1}'", 
            fileName, fullPath);
        _directory = fullPath;
        Read();
        HigherScore = Convert.ToInt32(highScore);
    }

    void Update()
    {

    }

    public void Write()
    {
        int Temp_Score = Convert.ToInt32(highScore);
        if (GM.score > Temp_Score)
        {
            highScore = GM.score.ToString();
        }

        string High_Score =  highScore;
        File.WriteAllText(_directory,High_Score);
    }

    public void Read()
    {
        Debug.LogFormat(_directory);
        highScore = File.ReadAllText(_directory);
    }
}
