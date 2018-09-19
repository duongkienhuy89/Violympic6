using UnityEngine;
using System.Collections;

public class StartThongThai : MonoBehaviour {

	public tk2dTextMesh txtContent;
	public tk2dSprite spTitle;
	public tk2dUIItem btnPlay;

	void onClick_btnPlay()
	{
		try
		{
		VioPopUpController.instance.HideStartThongThai();
		VioPopUpController.instance.ShowQuestionMonkey();
        SoundController.Instance.PlayClick();
		//SoundManager.Instance.PlayAudioChoiTiep();
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
		btnPlay.OnClick += onClick_btnPlay;
		if (VioGameController.instance.tienganh)
		{
			spTitle.SetSprite("monkey");
		}
		else
		{
			spTitle.SetSprite("khithongminh");
		}
	
		txtContent.text = ClsLanguage.doContentMoney();
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
