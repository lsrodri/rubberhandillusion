using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifetoggle : MonoBehaviour
{
    public GameObject knife;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("[9]"))
        {
            knife.SetActive(!knife.activeSelf);
        }

        if (knife.active)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            float y = 0f;
            if (Input.GetKey(KeyCode.KeypadPlus))
            {
                y = -0.5f;
            }
            else if (Input.GetKey(KeyCode.KeypadMinus))
            {
                y = 0.5f;
            }
            Vector3 movement = new Vector3(x, z, y);
            knife.transform.Translate(movement * .5f * Time.deltaTime);
        }

    }
}
