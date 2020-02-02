using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public bool click;
    public GameObject broken;
    public GameObject t;
    public GameObject ok;
    public GameObject cruz;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public int tipo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (click)
        {
            broken.GetComponent<spawn>().cont++;
            t.GetComponent<Image>().fillAmount = t.GetComponent<Image>().fillAmount + 0.2f;

            GetComponent<Collider2D>().enabled = false;
            var oki= Instantiate(ok, this.transform.position, Quaternion.identity);
            oki.transform.SetParent(transform);
            oki.transform.localPosition = new Vector3(0, 0, -1);
            if (tipo==1)
            {
                a1.SetActive(true);
            }
            if (tipo == 2)
            {
                a2.SetActive(true);
            }
            if (tipo == 3)
            {
                a3.SetActive(true);
            }
        }
        else
        {
            t.GetComponent<Image>().fillAmount = t.GetComponent<Image>().fillAmount - 0.2f;
            var cru=Instantiate(cruz, this.transform.position, Quaternion.identity);
            cru.transform.SetParent(transform);
            cru.transform.localPosition = new Vector3(0, 0, -1);
        }

        //Object.Destroy(this.gameObject);
    }
}
