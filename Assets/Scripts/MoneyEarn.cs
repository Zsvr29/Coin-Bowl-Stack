using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyEarn : MonoBehaviour
{
    public static MoneyEarn instance;
    public float counter;
    public TextMeshProUGUI text;

    void Start()
    {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = counter.ToString();
    }
}
