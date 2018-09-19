using UnityEngine;
using System.Collections;


public class Advertise : MonoBehaviour {

    public tk2dUIItem btnContinute;
    public tk2dUIItem btnCancel;
    public tk2dTextMesh txtTitle;
    public tk2dTextMesh txtContent;
 

 

  

    void onClick_Continute()
    {
	
		try
		{
		if (VioGameController.instance.tienganh && VioGameController.instance.vuotqua < 3) {

				AdManager.instance.ShowAdsInterstitial();
			} else {
				AdStartApp.instance.ShowFull();
			}
		}
		catch (System.Exception)
		{

			throw;
		}
       
    }
    void onClick_Cancel()
    {
		try
		{
        VioPopUpController.instance.HideAdTriger();
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

    public void setData()
    {
        AdManager.instance.LoadAdsInterstitial();
    }

	// Use this for initialization
	void Start () {
		try
		{
        btnContinute.OnClick += onClick_Continute;
        btnCancel.OnClick += onClick_Cancel;
        txtTitle.text = ClsLanguage.doQuangCao();
        txtContent.text = ClsLanguage.doContenQuangCao();
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
