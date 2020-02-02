using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject imagen;
    private Vector3 originalscale;
    private float t;
    public float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        originalscale = imagen.transform.localScale;
        t = -2;
        imagen.transform.localScale = Vector3.one * 0.001f;
    }
    private void Update()
    {
        t += Time.deltaTime * speed;
        imagen.transform.localScale = Vector3.Lerp(Vector3.one*0.001f,originalscale,t);

    }
    private void OnDestroy()
    {
        if (imagen) {
            imagen.transform.localScale = originalscale;
        }
        t = 0;
    }

    // Update is called once per frame



}
