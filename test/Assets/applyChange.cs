using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class applyChange : MonoBehaviour
{

    public Button doneButton;
    // Start is called before the first frame update
    void Start()
    {
        doneButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        gameManager._inst.titleScreen();
    }
        // Update is called once per frame
    void Update()
    {
        
    }
}
