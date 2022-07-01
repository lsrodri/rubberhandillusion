using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapProbe : MonoBehaviour
{

    public GameObject probe1;
    public GameObject probe2;
    public GameObject probe3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("[1]"))
        {
            probe1.SetActive(true);
            probe2.SetActive(false);
            probe3.SetActive(false);
        }

        if (Input.GetKey("[2]"))
        {
            probe1.SetActive(false);
            probe2.SetActive(true);
            probe3.SetActive(false);
        }

        if (Input.GetKey("[3]"))
        {
            probe1.SetActive(false);
            probe2.SetActive(false);
            probe3.SetActive(true);
        }

    }
    
}
