using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public static playerController instance;
    private int currentPoint = 0;
    public Text test;

    public bool hitState;
    private bool startGame;
    private bool startDelivery;

    public GameObject handLeft;
    public GameObject playBall;
    public GameObject opponentSide;

    void Start()
    {
        Debug.Log("handLeft postision " + handLeft.transform.position);
        startDelivery = false;
        startGame = false;
        changeTestText("Start game !!!");
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            releash();
        }

        // && !playBall.activeSelf
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) && !startGame && !playBall.activeSelf) 
        {
            releash();
        }
        else if (OVRInput.GetUp(OVRInput.RawButton.LIndexTrigger))
        {
            playBall.GetComponent<Rigidbody>().isKinematic = false;
            playBall.GetComponent<Rigidbody>().useGravity = true;
            playBall.GetComponent<Rigidbody>().detectCollisions = true;

            changeTestText("Button LIndexTrigger releash !!" + Random.Range(0, 10).ToString());
        }
    }

    private void releash()
    {
        Vector3 ballSpawn = new Vector3(handLeft.transform.position.x + 0.4f, handLeft.transform.position.y
    , handLeft.transform.position.z);

        Debug.Log(ballSpawn);

        playBall.transform.position = ballSpawn;
        playBall.transform.rotation = handLeft.transform.rotation;
        playBall.transform.localScale = handLeft.transform.localScale;


        playBall.SetActive(true);
        playBall.GetComponent<Rigidbody>().isKinematic = true;
        playBall.GetComponent<Rigidbody>().useGravity = false;
        playBall.GetComponent<Rigidbody>().detectCollisions = false;

        changeTestText("Button LIndexTrigger down !!" + Random.Range(0, 10).ToString());
    }

    public void changeTestText(string s)
    {
        test.text = s;
    }
}
