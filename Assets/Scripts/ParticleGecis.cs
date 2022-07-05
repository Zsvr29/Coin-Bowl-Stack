using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ParticleGecis : MonoBehaviour
{
    public static ParticleGecis instance;
  
  
    public void Start()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Picked"&& this.gameObject.tag=="FiveCent")
        {
            MoneyEarn.instance.counter += 2.5f;
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            


        }
        else if (other.gameObject.tag == "Picked" && this.gameObject.tag == "OneCent")
        {
            MoneyEarn.instance.counter += 1.5f;

            other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
          


        }
        else if (other.gameObject.tag == "Picked" && this.gameObject.tag == "TenCent")
        {
            MoneyEarn.instance.counter += 5f;


            other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            

        }
    }

   
}
