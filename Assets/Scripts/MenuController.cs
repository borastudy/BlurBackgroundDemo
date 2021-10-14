using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {
	[SerializeField] GameObject settingPanel;

	public void ShowSetting ()
	{
		settingPanel.SetActive (true);	
	}
	public void HideSetting ()
	{
		settingPanel.SetActive (false);	
	}

}
