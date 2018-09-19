using UnityEngine;
using System.Collections;

public class HoanThanh : MonoBehaviour {

	public tk2dTextMesh txtTitle;
	public tk2dTextMesh txtContent;
	public tk2dUIItem btnContinute;

	void onClick_btnContinute()
	{
		try
		{
		VioPopUpController.instance.HideHoanThanh();
		VioPopUpController.instance.ShowLevel();
        if (VioGameController.instance.tienganh)
        {
            SoundController.Instance.PlayClick();
        }
        else
        {
            SoundController.Instance.PlayTamBiet(true);
        }
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
		txtTitle.text = ClsLanguage.doTitleTuyetVoi();
		txtContent.text = ClsLanguage.doContentTuyetVoi();
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
