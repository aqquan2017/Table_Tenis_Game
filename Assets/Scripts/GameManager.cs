using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private AudioSource audioMain = new AudioSource();

    public AudioClip bgSound;
    public AudioClip interactSound;
    public AudioClip loseSound;
    public AudioClip winSound;

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
