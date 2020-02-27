using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Plane")
        {
            this.gameObject.SetActive(false);
            playerController.instance.changeTestText("Reset");
        }
        else if(collision.gameObject.name == "AiField")
        {
            //    playerController.instance.hitState = true;
            this.gameObject.SetActive(false);
            playerController.instance.changeTestText("Hit state !!! Score");
        }
        else if (collision.gameObject.name == "PlayerField")
        {
            //    playerController.instance.hitState = true;
            this.gameObject.SetActive(false);
            playerController.instance.changeTestText("Player Field !!! No Score");
        }
        
    }
}
