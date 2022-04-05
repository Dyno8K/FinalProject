using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trainingPlayer : MonoBehaviour
{
    public static player _instPlayer;

    public Rigidbody2D rb;
    public float dashPower;
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





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isAlive)
        { return; }
        DieVFX.Play();
        deathSFX.Play();
       

        //gameManager._inst.gameOver();
        //isAlive = false;
        //Destroy(gameObject);

        time1 = ((int)Time.time) + 2;
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
        Time.timeScale=1;
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
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D)))
        {
            shift();
        }


        if ((Input.GetKeyDown(KeyCode.Escape)) || Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(0);
        }


            float directiony = Input.GetAxisRaw("Vertical");


        if (dashCount == 0 && (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            dashSFX.Play();
            dash();
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
    void shift()
    {
        if (!isAlive)
        { return; }
        float direction = Input.GetAxisRaw("Horizontal");
        Vector2 dashVector1 = new Vector2(direction, 0f);
        rb.AddForce(dashVector1 * shiftPower * Time.deltaTime, ForceMode2D.Impulse);
    }
}
    
