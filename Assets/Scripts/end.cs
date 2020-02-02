using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject imagen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(imageRoutine());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator imageRoutine()
    {
        yield return new WaitForSecondsRealtime(1);
        imagen.SetActive(true);

    }

}
