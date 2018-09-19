using UnityEngine;
using System.Collections;

public class BuyItem : MonoBehaviour
{

    public tk2dTextMesh txtTitle;
    public tk2dTextMesh txtContent;
    public tk2dUIItem btnCancel;
    public tk2dUIItem btnBuy;

    void btnCancel_OnClick()
    {
		try
		{
        VioPopUpController.instance.HideBuyItem();
        VioPopUpController.instance.ShowMainGame();
        SoundController.Instance.PlayClick();
		if (VioGameController.instance.checkvip != 10) {
			if (VioGameController.instance.tienganh && VioGameController.instance.vuotqua < 3) {

				AdManager.instance.ShowBanner();
			} else {
				AdStartApp.instance.ShowBanner ();
			}
		}
		}
		catch (System.Exception)
		{

			throw;
		}
       
    }

    void btnBuy_OnClick()
    {
		try
		{
        IAPManager.instance.BuyVipLevel();
        SoundController.Instance.PlayClick();
		}
		catch (System.Exception)
		{

			throw;
		}
    }

    // Use this for initialization
    void Start()
    {
		try
		{
        btnCancel.OnClick += btnCancel_OnClick;
        btnBuy.OnClick += btnBuy_OnClick;
        txtTitle.text = ClsLanguage.doActiVip();
        txtContent.text = ClsLanguage.doContenVip();
		}
		catch (System.Exception)
		{

			throw;
		}

    }

    // Update is called once per frame
    void Update()
    {

    }
}
