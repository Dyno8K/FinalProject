using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class textScript : MonoBehaviour
{
    string path = @"C:\Users\malha\test\Assets\highScore.txt";

    public int timeScore;
    public static int highScore = 0;
    public static textScript _inst;
    private TextMeshProUGUI txt;
    public bool smallProblem = true; 

    public int HighScore(int x)
    {
        //x *= (int)(Time.deltaTime);
        if (x > highScore)
        {
            highScore = x;
            smallProblem = true;
            return highScore;
            
        }
        else
        {
            smallProblem = false;
            return highScore;
        }
    }

    static public void saveScore()
    {
        string path = @"C:\Users\malha\test\Assets\highScore.txt";
        File.WriteAllText(path, string.Format("{0}",highScore));
        //if (File.Exists(path))
        //{
        //    File.Delete(path);
        //}
        //else
        //{
        //    File.Create(path);
        //}
    }

    // Start is called before the first frame update
    void Start()

    {
        if (!File.Exists(path))
        {
            File.Create(path);

        }


        
        txt = GetComponent<TextMeshProUGUI>();
        string strScore= File.ReadAllText(path);
        
        
        highScore = int.Parse(strScore);
            
    }

    // Update is called once per frame
    void Update()
    {
        
        HighScore(timeScore);
        if (gameManager._inst.check == false)
        {
            float multiply = 60 * Time.timeSinceLevelLoad;
            timeScore = (int)multiply;
        }
        
        string x = string.Format("Highscore: {1} \n{0}", timeScore, highScore);
        txt.text = x;   


        
     
    }
}
