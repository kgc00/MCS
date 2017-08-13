using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManagerScript : MonoBehaviour {

	public GameObject customer;
	public Transform customerSpawnLocation;	
	public GameObject dialoguePanel;
	LoadBackgroundImageScript loadImageScript;
	CustomerScript customerScript;
	GameObject customerInstance;
	public Canvas inventoryCanvas;
	public Button customerButton;
	public bool openInventory;


	void Start()
	{
		customerScript = FindObjectOfType<CustomerScript>();
		loadImageScript = FindObjectOfType<LoadBackgroundImageScript> ();
		if (inventoryCanvas.isActiveAndEnabled){
			inventoryCanvas.gameObject.SetActive (false);
		}if (dialoguePanel.activeInHierarchy){
			dialoguePanel.gameObject.SetActive (false);
		} openInventory = true;
	}
	public void OnNewCustomer()
	{
		GameObject customerInstance = Instantiate(customer, customerSpawnLocation);
		customerScript.CustomerA ();
		dialoguePanel.gameObject.SetActive (true);
	}

	public void OnCustomerFinished()
	{
		GameObject test = FindObjectOfType<GameObject> ();
		Destroy (test);
		dialoguePanel.gameObject.SetActive (false);
	}

	public void OnNewCookingSession()
	{		
		loadImageScript.LoadImage ();
	}

	public void InventoryButtonClicked(){
		if (openInventory) {
			inventoryCanvas.gameObject.SetActive (true);
			customerButton.gameObject.SetActive (false);
			openInventory = false;
		} else if (!openInventory) {
			inventoryCanvas.gameObject.SetActive (false);
			customerButton.gameObject.SetActive (true);
			openInventory = true;
		}
	}
}
