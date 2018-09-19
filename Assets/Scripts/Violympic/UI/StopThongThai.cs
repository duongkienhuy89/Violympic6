using UnityEngine;
using System.Collections;

public class StopThongThai : MonoBehaviour {


	public tk2dTextMesh txtCoin;
	public tk2dTextMesh txtTime;
	public tk2dTextMesh txtHoanThanh;
	public tk2dUIItem btnContinute;
	public tk2dSprite titlemonkey;

	public void setData(int pCoin, string pTime)
	{
		try
		{
		//SoundManager.Instance.rePlayBGMusic();
		if (VioGameController.instance.checkvip != 10)
		{
			//Quang cao
		}

		//nativeExpressAdView.Show();
		txtCoin.text = ClsLanguage.doDiem()+": " + pCoin;
		txtTime.text = ClsLanguage.doTime()+": " + pTime;
		}
		catch (System.Exception)
		{

			throw;
		}
	}

	void onClick_btnContinute()
	{

		try
		{
        SoundController.Instance.PlayClick();
		if (VioGameController.instance.checkvip != 10)
		{
			//Hide quang cao
		}

		VioPopUpController.instance.HideStopThongThai ();
		VioPopUpController.instance.ShowStopGame ();
		}
		catch (System.Exception)
		{

			throw;
		}
	}

	// Use this for initialization
	void Start () {
		try
		{
		btnContinute.OnClick += onClick_btnContinute;

		txtHoanThanh.text = ClsLanguage.doHoanThanhBaiThi();
		if (VioGameController.instance.tienganh) {
			titlemonkey.SetSprite ("monkey");
		} else {
			titlemonkey.SetSprite ("khithongminh");
		}
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
