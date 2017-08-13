using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBackgroundImageScript : MonoBehaviour {

	public Sprite myImage;

	// Use this for initialization
	void Start () {
		myImage = GetComponent<SpriteRenderer> ().sprite;
	}
	
	public void LoadImage()
	{
		GetComponent<SpriteRenderer> ().sprite = Resources.Load <Sprite>("Sprites/food prep");
	}
}
