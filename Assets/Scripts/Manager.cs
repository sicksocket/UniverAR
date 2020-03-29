using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(go1.active && go2.active)
        {
            Vector3 targetPos1 = new Vector3(go1.transform.position.x, transform.position.y, go1.transform.position.z);
            Vector3 targetPos2 = new Vector3(go2.transform.position.x, transform.position.y, go2.transform.position.z);
            go1.transform.LookAt(targetPos2);
            go2.transform.LookAt(targetPos1);
            go1.GetComponent<Animator>().SetBool("Start", true);
            go2.GetComponent<Animator>().SetBool("Start", true);
        }
        else{
            go1.GetComponent<Animator>().SetBool("Start", false);
            go2.GetComponent<Animator>().SetBool("Start", false);
        }
    }
}
