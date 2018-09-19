using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public tk2dUIItem btnVaoThi;
	public tk2dUIItem btnBack;
	public tk2dTextMesh txtTitle;
	public tk2dTextMesh txtContent;


	void onClick_Back()
	{
		try
		{
		VioPopUpController.instance.HideStartGame();
		VioPopUpController.instance.ShowLevel();
        SoundController.Instance.PlayClick();
		}
		catch (System.Exception)
		{

			throw;
		}


      
	}

	void onClick_VaoThi()
	{
		try
		{
		VioPopUpController.instance.HideStartGame();

		VioGameController.instance.ShowLevel1();
		VioGameController.instance.ckResetLv = false;

        SoundController.Instance.PlayChoiTiep();
		}
		catch (System.Exception)
		{

			throw;
		}
	}
	public void setData()
	{
		txtTitle.text = ClsLanguage.doBatDau() + VioGameController.instance.level;

	}

	// Use this for initialization
	void Start () {
		try
		{
		btnVaoThi.OnClick += onClick_VaoThi;
		btnBack.OnClick += onClick_Back;

		txtContent.text = ClsLanguage.doContentBatDau();
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
