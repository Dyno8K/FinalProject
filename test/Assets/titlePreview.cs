using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlePreview : MonoBehaviour
{
    public GameObject green;
    public GameObject blue;
    public GameObject red;
    public GameObject white;
    public GameObject pink;
    public GameObject orange;
    public GameObject yellow;
    public GameObject yoda;


    // Start is called before the first frame update
    void Start()
    {
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
