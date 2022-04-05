using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    public static player _instPlayer;

    public Rigidbody2D rb;
    public float dashPower ;
    public float dashJump;
    public float torquePower;
    public float shiftPower;
    public float jump;

    bool isAlive = true;
    public GameObject green;
    public GameObject blue;
    public GameObject red;
    public GameObject white;
    public GameObject pink;
    public GameObject orange;
    public GameObject yellow;
    public GameObject yoda;
    public AudioSource deathSFX;
    public AudioSource dashSFX;
    public GameObject greenT;
    public GameObject blueT;
    public GameObject redT;
    public GameObject whiteT;
    public GameObject pinkT;
    public GameObject orangeT;
    public GameObject yellowT;
    public ParticleSystem DieVFX, DashVFX;
    
    int dashCount = 0;
    int time;
    public static int time1;

    public static bool isPaused;
    GameObject[] pauseObjects;

    public GameObject controlMenu;


    private void OnTriggerEnter2D(Collider2D collision)
    {   if (!isAlive)
            { return; }
        DieVFX.Play();
        deathSFX.Play();
        green.SetActive(false);
        blue.SetActive(false);
        red.SetActive(false);
        white.SetActive(false);
        pink.SetActive(false);
        orange.SetActive(false);
        yellow.SetActive(false);
        greenT.SetActive(false);
        blueT.SetActive(false);
        redT.SetActive(false);
        whiteT.SetActive(false);
        pinkT.SetActive(false);
        orangeT.SetActive(false);
        yellowT.SetActive(false);
        yoda.SetActive(false);
   
        gameManager._inst.gameOver();
        isAlive = false;
        //Destroy(gameObject);
        
        time1 = ((int)Time.time)+2 ;
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        // if (collide.gameobject.tag == "Player")
        if (col.gameObject.tag == "floor")
        {
            
            dashCount = 0;
            //StartCoroutine(wait(waitTime));
        }
        


    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();

        green.SetActive(false);
        blue.SetActive(false);
        red.SetActive(false);
        white.SetActive(false);
        pink.SetActive(false);
        orange.SetActive(false);
        yellow.SetActive(false);
        greenT.SetActive(false);
        blueT.SetActive(false);
        redT.SetActive(false);
        whiteT.SetActive(false);
        pinkT.SetActive(false);
        orangeT.SetActive(false);
        yellowT.SetActive(false);
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
        switch (gameManager.trailcolor)
        {
            case "green":
                greenT.SetActive(true);
                break;
            case "red":
                redT.SetActive(true);
                break;
            case "blue":
                blueT.SetActive(true);
                break;
            case "white":
                whiteT.SetActive(true);
                break;
            case "pink":
                pinkT.SetActive(true);
                break;
            case "orange":
                orangeT.SetActive(true);
                break;
            case "yellow":
                yellowT.SetActive(true);
                break;

        }

    }



    // Update is called once per frame
    void Update()
    {
        void PauseGame()
        {
            if (isPaused)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else
            {
                Time.timeScale = 1;
                hidePaused();
                controlMenu.SetActive(false);
                
            }
            
        }
        if ((Input.GetKeyDown(KeyCode.Escape))|| Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            PauseGame();
            
        }

        
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D)))
        {
            shift();
        }





        float directiony = Input.GetAxisRaw("Vertical");


        if (dashCount == 0 && (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            dashSFX.Play();
            dash();
        }



       





    }
    public void showPaused()
    {
                
        foreach (GameObject g in pauseObjects)
        {
            
            g.SetActive(true);
        }
    }
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
    void shift()
    {
        if (!isAlive)
        { return; }
        float direction = Input.GetAxisRaw("Horizontal");
        Vector2 dashVector1 = new Vector2(direction, 0f);
        rb.AddForce(dashVector1 * shiftPower* Time.deltaTime, ForceMode2D.Impulse);
    }
    void dash()
    {
        if (!isAlive)
        { return; }
        dashCount++;


        float direction = Input.GetAxisRaw("Horizontal");
        Vector2 dashVector = new Vector2(direction, dashJump);
        rb.AddForce(dashVector * dashPower, ForceMode2D.Impulse);
        DashVFX.Play();
        rb.AddTorque(torquePower * -direction, ForceMode2D.Impulse);

    }

}
