using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class facing : MonoBehaviour

{
    public bool effect=false;
    public float speed=1;
    private Image imagen;

    void Start()
    {
        imagen = GetComponent<Image>();
        var color = imagen.color;
        color.a = 0;
        imagen.color = color;
    }

    void Update()
    {
        if (!effect) return;
        var c = imagen.color;
        c.a += Time.deltaTime * speed;
        imagen.color = c;
    }
}
