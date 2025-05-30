using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllers : MonoBehaviour
{
    public GameObject colobusObj;
    Animator colobusAnim;
    // Start is called before the first frame update
    void Start()
    {
        colobusAnim = colobusObj.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            sit();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            roll();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            jump();
        }

    }

    public void sit()
    {
        colobusAnim.SetTrigger("sit");
    }

    public void roll()
    {
        colobusAnim.SetTrigger("roll");
    }

    public void jump()
    {
        colobusAnim.SetTrigger("jump");
    }
}
