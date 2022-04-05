using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leftArrow : MonoBehaviour
{
    public GameObject green;
    public GameObject blue;
    public GameObject red;
    public GameObject white;
    public GameObject pink;
    public GameObject orange;
    public GameObject yellow;
    public GameObject yoda;

    public Button arrowL;
    // Start is called before the first frame update
    void Start()
    {
        arrowL.onClick.AddListener(TaskOnClick);
        switch (gameManager.color)
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
            case "yoda":
                yoda.SetActive(true);
                break;

        }
    }

    void TaskOnClick()
    {
        if (gameManager.skinChoice != 0)
        {
            gameManager.skinChoice -= 1;
        }
        else if (gameManager.skinChoice == 0)
        {
            gameManager.skinChoice = 7;
        }
        gameManager.color = gameManager.skinList[gameManager.skinChoice];

        green.SetActive(false);
        blue.SetActive(false);
        red.SetActive(false);
        white.SetActive(false);
        pink.SetActive(false);
        orange.SetActive(false);
        yellow.SetActive(false);
        yoda.SetActive(false);

        switch (gameManager.color)
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
            case "yoda":
                yoda.SetActive(true);
                break;

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
