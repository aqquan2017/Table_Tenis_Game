using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public AudioSource bgSound;
    public AudioSource interactSound;
    public AudioSource loseSound;
    public AudioSource winSound;

    public bool turnState = true;

    private const int winPoint = 11;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkWinner()
    {

    }
    public void gameProcess()
    {

    }
    public void scoreDisplay()
    {

    }
    public void showWinner()
    {

    }

}
