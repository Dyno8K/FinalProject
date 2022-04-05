using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class freeplayButton : MonoBehaviour
{
    public Button freeplay,control,X, campaign, exit, training, customize;
    public GameObject controlMenu;

    // Start is called before the first frame update
    void Start()
    {
        
        freeplay.onClick.AddListener(TaskOnClick);
        control.onClick.AddListener(controlMenuButton);
        X.onClick.AddListener(controlX);
        //campaign.onClick.AddListener(campaignbutton);
        exit.onClick.AddListener(exitFunc);
        training.onClick.AddListener(trainingbutton);
        customize.onClick.AddListener(customizebutton);
        
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }
    void controlMenuButton()
    {
        controlMenu.SetActive(true);
    }
    void controlX()
    {
        controlMenu.SetActive(false);
    }
    //void campaignbutton()
    //{
    //    SceneManager.LoadScene(4);
    //}
    void exitFunc()
    {
        Application.Quit();
    }
    void trainingbutton()
    {
        SceneManager.LoadScene(3);
    }
    void customizebutton()
    {
        SceneManager.LoadScene(2);
    }

   

}
