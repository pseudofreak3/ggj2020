using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    private float con;
    float time;
    public GameObject final;
    bool fin=true;
    void Start()
    {
        con = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time +=con* Time.deltaTime;
        GetComponent<Image>().fillAmount = GetComponent<Image>().fillAmount - (Time.deltaTime/10);
        if (GetComponent<Image>().fillAmount==0 && fin)
        {
            //SceneManager.LoadScene("Menu");            
            fin = false;
            StartCoroutine(endRoutine());

        }
    }

    private IEnumerator endRoutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("Badend");

    }
}
