using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    bool isTap = true;

    void Start()
    {
        GameObject.Find("Parent").GetComponent<LerpMechanic>().enabled = false;  // hareket etmemesi için kapattýk
        GameObject.Find("Parent").GetComponent<Movement>().enabled = false;

    }
    private void Update()

    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isTap == true)
            {
                GameObject.Find("Parent").GetComponent<LerpMechanic>().enabled = true;
                GameObject.Find("Parent").GetComponent<Movement>().enabled = true;

                this.gameObject.SetActive(false);
                isTap = false;
            }
        }
    }
}
