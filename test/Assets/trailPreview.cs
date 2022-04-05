using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trailPreview : MonoBehaviour
{
    public Button trailL;
    public Button trailR;


    public GameObject green;
    public GameObject blue;
    public GameObject red;
    public GameObject white;
    public GameObject pink;
    public GameObject orange;
    public GameObject yellow;

   
    // Start is called before the first frame update
    void Start()
    {
        switch (gameManager.trailcolor)
        {
            case "green":
                green.SetActive(true);
                break;
            case "red":
                red.SetActive(true);
                break;
            case "blue":
                blue.SetActive(true);
                break;
            case "white":
                white.SetActive(true);
                break;
            case "pink":
                pink.SetActive(true);
                break;
            case "orange":
                orange.SetActive(true);
                break;
            case "yellow":
                yellow.SetActive(true);
                break;

        }
        trailL.onClick.AddListener(TaskOnClick);
        trailR.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (gameManager.trailChoice != 0)
        {
            gameManager.trailChoice -= 1;
        }
        else if (gameManager.trailChoice == 0)
        {
            gameManager.trailChoice = 6;
        }
        gameManager.trailcolor = gameManager.trailList[gameManager.trailChoice];

        green.SetActive(false);
        blue.SetActive(false);
        red.SetActive(false);
        white.SetActive(false);
        pink.SetActive(false);
        orange.SetActive(false);
        yellow.SetActive(false);

        switch (gameManager.trailcolor)
        {
            case "green":
                green.SetActive(true);
                break;
            case "red":
                red.SetActive(true);
                break;
            case "blue":
                blue.SetActive(true);
                break;
            case "white":
                white.SetActive(true);
                break;
            case "pink":
                pink.SetActive(true);
                break;
            case "orange":
                orange.SetActive(true);
                break;
            case "yellow":
                yellow.SetActive(true);
                break;

        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}


