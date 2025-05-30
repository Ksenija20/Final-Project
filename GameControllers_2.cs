using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllers_2 : MonoBehaviour
{
    public GameObject geckoObj;
    Animator geckoAnim;
    // Start is called before the first frame update
    void Start()
    {
        geckoAnim = geckoObj.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            run();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            eat();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bounce();
        }

    }

    public void run()
    {
        geckoAnim.SetTrigger("run");
    }

    public void eat()
    {
        geckoAnim.SetTrigger("eat");
    }

    public void bounce()
    {
        geckoAnim.SetTrigger("bounce");
    }
}
