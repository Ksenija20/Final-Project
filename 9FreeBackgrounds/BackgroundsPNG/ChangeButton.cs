using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    public GameObject Background7;
    public GameObject Background6;
    public bool isBackground7 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackGroundChange()
    {
        if(isBackground7 == false)
        {
            Background7.SetActive(true);
            Background6.SetActive(false);
            isBackground7 = true;
        }

        else
        {
            Background6.SetActive(true);
            Background7.SetActive(false);
            isBackground7 = false;
        }
        
    }

}
