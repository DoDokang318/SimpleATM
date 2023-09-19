using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject FirstPopup;
    [SerializeField]
    private GameObject CreditPopup;
    [SerializeField]
    private GameObject WithdrawPopup;

    [SerializeField]
    private Button BtnCreditPopup;
    [SerializeField]
    private Button BtnWithdrawPopup;
    [SerializeField]
    private Button BtnCreditPopupExit;
    [SerializeField]
    private Button BtnWithdrawPopupExit;


    public void Start()
    {
        BtnCreditPopup.onClick.AddListener(() =>
        {
            Popup(CreditPopup,FirstPopup);
        });

        BtnWithdrawPopup.onClick.AddListener(() =>
        {
            Popup(WithdrawPopup,FirstPopup);
        });
        BtnCreditPopupExit.onClick.AddListener(() =>
        {
            Popup(FirstPopup,CreditPopup);
        });
        BtnWithdrawPopupExit.onClick.AddListener(() =>
        {
            Popup(FirstPopup,WithdrawPopup);
        });

    }


    private void Popup(GameObject OngameObject,GameObject OffgameObject)
    {
        OngameObject.SetActive(true);
        OffgameObject.SetActive(false);
    

    }

}
