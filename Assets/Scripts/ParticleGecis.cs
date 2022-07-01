using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ParticleGecis : MonoBehaviour
{
    public static ParticleGecis instance;
    public TextMeshProUGUI text;
   float sayac1,sayac2,sayac3;
   public float sayac;
    public void Start()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Picked"&& this.gameObject.tag=="FiveCent")
        {
            sayac1 += 2.5f;
            text.text = sayac.ToString();
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Debug.Log(sayac1);


        }
        else if (other.gameObject.tag == "Picked" && this.gameObject.tag == "OneCent")
        {
            sayac2 += 1.5f;
            text.text = sayac.ToString();
            other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            Debug.Log(sayac2);


        }
        else if (other.gameObject.tag == "Picked" && this.gameObject.tag == "TenCent")
        {
            sayac3 += 5f; 
            text.text = sayac.ToString();
            other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            Debug.Log(sayac3);

        }
    }

    private void Update()
    {
        sayac = sayac1 + sayac2 + sayac3;
       
        text.text = sayac.ToString();
        
    }
}
