using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerScript : MonoBehaviour {

	public Text customerText;
	public string inputText;
	public Canvas buttonCanvas;
	public Canvas debugCanvas;
	bool buttonPressed;
	EventManagerScript eMS;
	public Canvas portraitCanvas;

	void Start()
	{
		eMS = FindObjectOfType<EventManagerScript>();
		if (buttonCanvas.isActiveAndEnabled) 
		{
			buttonCanvas.gameObject.SetActive (false);
		} if (portraitCanvas.isActiveAndEnabled){
			portraitCanvas.gameObject.SetActive (false);
		}
	}

	public void CustomerA()
	{
		customerText.text = inputText;
		buttonCanvas.gameObject.SetActive (true);
		debugCanvas.gameObject.SetActive (false);
		portraitCanvas.gameObject.SetActive (true);
	}

	public void YesButtonPressed(){
		debugCanvas.gameObject.SetActive (true);
		buttonCanvas.gameObject.SetActive (false);
		portraitCanvas.gameObject.SetActive (false);
		buttonPressed = true;
		Debug.Log (buttonPressed);
		eMS.OnCustomerFinished ();
		customerText.text = null;
	}

	public void NoButtonPressed(){
		debugCanvas.gameObject.SetActive (true);
		buttonCanvas.gameObject.SetActive (false);
		portraitCanvas.gameObject.SetActive (false);
		buttonPressed = false;
		Debug.Log (buttonPressed);
		eMS.OnCustomerFinished ();
		customerText.text = null;
	}
}
