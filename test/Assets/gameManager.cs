using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
   

    public static gameManager _inst;
    public bool check = false;
    public int gameCount = 0;

    public static string color = "green";
    public static string trailcolor = "green";
    public static  int skinChoice = 0;
    public static int trailChoice = 0;
    public static string[] skinList = { "green", "red", "white", "blue", "pink", "orange", "yellow", "yoda" };
    public static string[] trailList = { "green", "red", "white", "blue", "pink", "orange", "yellow" };

    double time1;

    private void Awake()
    {
        _inst = this;
    }

    IEnumerator wait(float f)
    {
        yield return new WaitForSeconds(f);                 
        
    }

    public textScript text2;
    
    void Start()
    {
        
        check = false;
        gameCount = 0;  

}

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.M) || (Input.GetKeyDown(KeyCode.Escape)))
        //{
        //    gameManager._inst.titleScreen();
        //}

    }

    public void gameOver()
    {
        check = true;
        textScript.saveScore();
        Invoke(nameof(restartLevel), 2f);
        Invoke(nameof(ResumeGame), 2f);
        gameCount += 1;

        
    }

    public static void ifEscape()
    {
        if (Input.GetKey(KeyCode.Escape) || (Input.GetKey(KeyCode.M)))
        {
            SceneManager.LoadScene(0);  
        }
        
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void titleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
