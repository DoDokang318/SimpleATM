using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cash : MonoBehaviour
{
    public  int Money;
    public TextMeshProUGUI TextCash;
    GameManager gameManager;
   
    public void Awake()
    {
        gameManager = GameManager.Instance;       
   
    }
    private void Start()
    {
        CurrentCash();
    }

    public void CurrentCash()
    {
        TextCash.text =Money.ToString();
    }

}
