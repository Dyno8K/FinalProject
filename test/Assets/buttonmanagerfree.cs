using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonmanagerfree : MonoBehaviour
{
    public Button backToMenu, replay, controls, X;
    public GameObject controlMenu;


    // Start is called before the first frame update
    void Start()
    {
        backToMenu.onClick.AddListener(TaskOnClick);
        replay.onClick.AddListener(TaskOnClick2);
        controls.onClick.AddListener(TaskOnClick3);
        X.onClick.AddListener(TaskOnClick4);
    }
    void TaskOnClick()
    {

        gameManager._inst.titleScreen();
    }
    void TaskOnClick2()
    {

        gameManager._inst.restartLevel();
    }
    void TaskOnClick3()
    {
        controlMenu.SetActive(true);
            
        
    }
    void TaskOnClick4()
    {
        controlMenu.SetActive(false);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
