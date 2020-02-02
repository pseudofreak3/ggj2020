using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fading : MonoBehaviour

{

    public float speed=1;
    private Image imagen;

    void Start()
    {
        imagen = GetComponent<Image>();
        var color = imagen.color;
        color.a = 1;
        imagen.color = color;
    }

    void Update()
    {
        
        var c = imagen.color;
        c.a -= Time.deltaTime * speed;
        c.a = Mathf.Clamp01(c.a);
        imagen.color = c;
    }
}
