using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public int cont =0;
    public item[] prefab;
    private List<int> posb= new List<int>();

    public Transform[] pos;
    public GameObject timer;
    public GameObject oki;
    public GameObject cru;
    public GameObject final;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public facing facing;




    bool fin =true; 

    // Start is called before the first frame update
    void Start()
    {
        timer.GetComponent<timer>().enabled = true;

        for (int i = 0; i < pos.Length; i++)
        {
            int p = 0;
            while (posb.Contains(p))
            {
                p = Random.Range(0, prefab.Length);
            }
            posb.Add(p);

            item ch1 = Instantiate(prefab[p]);
            ch1.transform.SetParent(pos[i].parent, false);           
            ch1.transform.localPosition = pos[i].localPosition;

            ch1.broken = gameObject;
            ch1.t = timer;
            ch1.ok = oki;
            ch1.cruz = cru;
            ch1.a1 = b1;
            ch1.a2 = b2;
            ch1.a3 = b3;

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (cont>=3 && fin)
        {
            b4.SetActive(true);
            fin = false;
            //Object.Destroy(this.gameObject);
            timer.GetComponent<timer>().enabled = false;
            StartCoroutine(gameRoutine());

            
        }
    }

    private IEnumerator gameRoutine()
    {
        facing.effect = true;
        yield return new WaitForSecondsRealtime(2);

        SceneManager.LoadScene("Goodend");

    }

}
