﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void start()
    {
        SceneManager.LoadScene("Game");
       

    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void anima()
    {
        SceneManager.LoadScene("Animation");
    }


}
