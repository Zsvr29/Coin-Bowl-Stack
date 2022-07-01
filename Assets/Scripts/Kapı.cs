using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Kapı : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Picked"&&this.name=="Bigger")
        {
          other.transform.localScale=new Vector3(other.gameObject.transform.localScale.x+0.2f,other.gameObject.transform.localScale.y+0.2f,other.gameObject.transform.localScale.z);
        }
        else if (other.gameObject.tag=="Picked"&& this.name=="Smaller")
        {

            other.transform.localScale = new Vector3(other.gameObject.transform.localScale.x -(0.1f), other.gameObject. transform.localScale.y -(0.1f), other.transform.localScale.z);
        }
       
    }
    
}
