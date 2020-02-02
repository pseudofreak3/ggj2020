using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CinematicaScript : MonoBehaviour

{
    private bool flagskipbutton = false;
    public GameObject[] objs;
    private float currentTime;
    public float maxTimeWait = 4;
    public Button skipButton;
    public float lastTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        skipButton.onClick.AddListener(OnSkip);
        StartCoroutine(cinematicRoutine());
    }

    private void OnSkip()
    {
        flagskipbutton = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
    }

    void activeIndex( int index)
    {
        for (int i = 0; i < objs.Length; i++)
        {
            objs[i].SetActive(i == index);

        }
    }

    private bool canSkip() 
    {
        return Input.GetKeyDown(KeyCode.Space) || flagskipbutton || currentTime>maxTimeWait;
    }

    private IEnumerator cinematicRoutine() {

        for (int i = 0; i < objs.Length; i++)
        {
            activeIndex(i); 
            yield return null;
            currentTime = 0;
            flagskipbutton = false;
            while (!canSkip()) { yield return null; }
            print("Skip");
            flagskipbutton = false;

        }
        yield return new WaitForSecondsRealtime(lastTime);
        SceneManager.LoadScene("game");
    }

}
