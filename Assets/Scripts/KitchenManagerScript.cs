using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenManagerScript : MonoBehaviour {
	
	LoadBackgroundImageScript loadImageScript;
	public Canvas kitchenCanvas;
	public Canvas cookingCanvas;
	public Canvas combiningCanvas;
	public Canvas mixingCanvas;
	public Canvas doughCanvas;
	public Canvas meatMixingCanvas;
	public Canvas meatPouringCanvas;

	public void Start()
	{
		loadImageScript = FindObjectOfType<LoadBackgroundImageScript> ();
	}

	public void OnNewCookingSession()
	{		
		//loadImageScript.LoadImage ();
		if (kitchenCanvas.isActiveAndEnabled) {
			kitchenCanvas.gameObject.SetActive (false);
		} if (cookingCanvas.isActiveAndEnabled == false){
			cookingCanvas.gameObject.SetActive(true);
		} 
		MeatPieRecipe ();
	}

	public void MeatPieRecipe()
	{
		if (combiningCanvas.isActiveAndEnabled == false){
			combiningCanvas.gameObject.SetActive(true);
		}	
	}

	public void MeatPieCanvasOneButtons(int image)
	{
		if (image == 0) {
			Debug.Log ("Water");
		} else if (image == 1) {
			Debug.Log ("Flour");
		} else if (image == 2) {
			Debug.Log ("Butter");
		} else {
			Debug.Log ("Eggs");
		}
	}
}
