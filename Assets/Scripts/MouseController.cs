using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float speedsize = 1;
    private Vector3 current;
    private Vector3 desired;
    private float z = 0;
    private float t = 0;
    Vector3 initialScale, clickedScale;
    // Start is called before the first frame update
    void Start()
    {
       z = transform.position.z;
        initialScale = transform.localScale;
        clickedScale = initialScale * 0.75f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = z;
        transform.position = pos;


        Vector3 scale = initialScale;
        if (Input.GetMouseButton(0))
        {
            scale = clickedScale;
        }
        if (Input.GetMouseButtonDown(0)) {
            t = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            t = 0;
        }
        t +=Time.deltaTime *speedsize;
        // transform.localScale = scale;

        desired = scale;
        current = Vector3.Lerp(current, desired, t);
        transform.localScale = current;
    }
}
