using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllers_03 : MonoBehaviour


{
    public GameObject squidObj;
    Animator squidAnim;
    //AudioSource squidAudio;
    //public AudioClip squidClip;
    // Start is called before the first frame update
    void Start()
    {
        squidAnim = squidObj.GetComponent<Animator>();
        //squidAudio = squidObj.GetComponent<AudioSource>();
}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            hit();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            fear();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            attack();
        }
       

    }

    public void hit()
    {
        squidAnim.SetTrigger("hit");
    }

    public void fear()
    {
        squidAnim.SetTrigger("fear");
    }

    public void attack()
    {
        squidAnim.SetTrigger("attack");
    }
    
    

}

