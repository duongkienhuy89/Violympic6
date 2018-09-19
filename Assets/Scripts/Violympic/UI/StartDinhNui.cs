using UnityEngine;
using System.Collections;

public class StartDinhNui : MonoBehaviour {

	public tk2dUIItem btnVaoThi;
	public tk2dTextMesh txtTitle;
	public tk2dTextMesh txtContent;




	public void setData(int lesson)
	{
		try
		{
		txtContent.text = ClsLanguage.doLesson() + lesson + ":" + ClsLanguage.doContentDinhNui();
        SoundController.Instance.PlayBGMusic();
		}
		catch (System.Exception)
		{

			throw;
		}
	}

	void btnVaoThi_onClick()
	{
		try
		{
		VioPopUpController.instance.HideStartDinhNui();
		VioPopUpController.instance.ShowQuestionDinhNui();
        SoundController.Instance.PlayClick();
		}
		catch (System.Exception)
		{

			throw;
		}
        
		//SoundManager.Instance.PlayAudioChoiTiep();
	}

	// Use this for initialization
	void Start () {
		try
		{
		btnVaoThi.OnClick += btnVaoThi_onClick;
		txtTitle.text = ClsLanguage.doTitleDinhNui();
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
