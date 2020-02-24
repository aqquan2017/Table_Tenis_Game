using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public Text test;

    public static playerController instance;

    private int currentPoint = 0;

    public bool hitState;
    public GameObject opponentSide;

    // Start is called before the first frame update
    void Start()
    {     
        changeTestText("Start game !!!");
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.RawButton.X)) 
        {
            changeTestText("Button A or X clicked !!");
        }
        else if (OVRInput.GetUp(OVRInput.Button.One))
        {
            changeTestText("Button A releash !!");
        }
    }

    private void changeTestText(string s)
    {
        test.text = s;
    }

    
}
