using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VioMainGame : MonoBehaviour {


	public tk2dUIItem btnPlay;
	public tk2dUIItem btnBuyVip;
	public tk2dUIItem btnALTP;
    public tk2dUIItem btnShare;
    public tk2dUIItem btnRate;


    void onClick_Share()
    {
		try
		{
        ShareRate.Share();
		}
		catch (System.Exception)
		{

			throw;
		}
    }

    void onClick_Rate()
    {
		try
		{
        if (VioGameController.instance.tienganh)
        {
            ShareRate.Rate();
        }
        else
        {
            ShareRate.RateBird();
        }
		}
		catch (System.Exception)
		{

			throw;
		}
    }

	void onClick_Play()
	{
		try
		{
		VioPopUpController.instance.ShowLevel ();
		VioPopUpController.instance.HideMainGame ();
        SoundController.Instance.PlayClick();

		if (VioGameController.instance.checkvip != 10) {
			if (VioGameController.instance.tienganh && VioGameController.instance.vuotqua < 3) {

				AdManager.instance.HideBaner();
			} else {
				AdStartApp.instance.HideBanner ();
			}
		}
		}
		catch (System.Exception)
		{

			throw;
		}

     

	}
	void onClick_BuyVip()
	{
		try
		{
		VioPopUpController.instance.HideMainGame ();
        VioPopUpController.instance.ShowBuyItem();
        SoundController.Instance.PlayClick();
		if (VioGameController.instance.checkvip != 10) {
			if (VioGameController.instance.tienganh && VioGameController.instance.vuotqua < 3) {

				AdManager.instance.HideBaner ();
			} else {
				AdStartApp.instance.HideBanner ();
			}
		}
		}
		catch (System.Exception)
		{

			throw;
		}
	}
	void onClick_ALTP()
	{
		try
		{
        SoundController.Instance.PlayClick();
		VioPopUpController.instance.HideMainGame ();
		if (VioGameController.instance.checkvip != 10) {
			if (VioGameController.instance.tienganh && VioGameController.instance.vuotqua < 3) {

				AdManager.instance.HideBaner ();
			} else {
				AdStartApp.instance.HideBanner ();
			}
		}

        if (!VioGameController.instance.tienganh)
        {
            SceneManager.LoadScene("InGame");
        }
        else
        {
            
            VioPopUpController.instance.ShowAdTriger();
        }
		}
		catch (System.Exception)
		{

			throw;
		}
	}

	public void setData()
	{
		
	}

	// Use this for initialization
	void Start () {
		try
		{
		btnPlay.OnClick += onClick_Play;
		btnBuyVip.OnClick += onClick_BuyVip;
		btnALTP.OnClick += onClick_ALTP;
        btnRate.OnClick += onClick_Rate;
        btnShare.OnClick += onClick_Share;
		}
		catch (System.Exception)
		{

			throw;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
