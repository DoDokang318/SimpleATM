using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject CurrentCash;
    [SerializeField]
    private GameObject BankCash;

    public static GameManager Instance;
    private Cash cash;

    public delegate void UpdateCash(); //¿‘±›
    public delegate void OutCash(); // √‚±› 

    public event UpdateCash Updatecassh;

    Cash Currentcash;
    Cash bankCash;

  [Header("In")]

    [SerializeField]
    private Button In10000;
    [SerializeField]
    private Button In30000;
    [SerializeField]
    private Button In50000;

    [SerializeField]
    private TMP_InputField inputFieldIn;
    [SerializeField]
    private Button BtnInputFieldIn;


    [Header("Out")]

    [SerializeField]
    private Button Out10000;
    [SerializeField]
    private Button Out30000;
    [SerializeField]
    private Button Out50000;

    [SerializeField]
    private TMP_InputField inputFieldOut;
    [SerializeField]
    private Button BtnInputFieldOut;


    private void Awake()
    {

        Currentcash = CurrentCash.GetComponent<Cash>();
        bankCash = BankCash.GetComponent<Cash>();
        Instance = this;

        Updatecassh += Currentcash.CurrentCash;
        Updatecassh += bankCash.CurrentCash;


    }
    private void Start()
    {
        In10000.onClick.AddListener(() =>
        {
            InMoney(10000);

        });

        In30000.onClick.AddListener(() =>
        {
            InMoney(30000);
        });

        In50000.onClick.AddListener(() =>
        {

            InMoney(50000);
        });

        BtnInputFieldIn.onClick.AddListener(() =>
        {
            InMoney(int.Parse(inputFieldIn.text));

        });


        Out10000.onClick.AddListener(() =>
        {
            OutMoney(10000);

        });
        Out30000.onClick.AddListener(() =>
        {

            OutMoney(30000);
        });
        Out50000.onClick.AddListener(() =>
        {
            OutMoney(50000);

        });

        BtnInputFieldOut.onClick.AddListener(() =>
        {
            OutMoney(int.Parse(inputFieldOut.text));

        });
    }

    


    public void InMoney(int Money)
    {

        if (Currentcash.Money >=Money)
        {
            bankCash.Money += Money;
            Currentcash.Money -= Money;
            Updatecassh();
        }
        else
        {        
            Debug.Log("µ∑∫Œ¡∑");
       
        }

    }

    public void OutMoney(int Money)
    {

        int MyMoney = Currentcash.Money;
        int BankMoney = bankCash.Money;

        if (bankCash.Money >= Money)
        {
            bankCash.Money -= Money;
            Currentcash.Money += Money;
            Updatecassh();
        }
        else
        {
            Debug.Log("µ∑∫Œ¡∑");

        }

    }

}
