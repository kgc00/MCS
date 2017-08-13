using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenManagerScript : MonoBehaviour {
	
	LoadBackgroundImageScript loadImageScript;
	public Canvas kitchenCanvs;

	public void Start()
	{
		loadImageScript = FindObjectOfType<LoadBackgroundImageScript> ();
	}

	public void OnNewCookingSession()
	{		
		loadImageScript.LoadImage ();
		if (kitchenCanvs.isActiveAndEnabled) {
			kitchenCanvs.gameObject.SetActive (false);
		}
	}

	public void SetUpKitche()
	{
		
		//BackOfHouseButton.gameObject.SetActive (true);
	}
}
