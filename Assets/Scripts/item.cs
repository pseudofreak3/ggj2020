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

            
            var oki= Instantiate(ok, this.transform.position, Quaternion.identity);
            oki.transform.SetParent(transform);
            oki.transform.localPosition = new Vector3(0, 0, -1);

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
