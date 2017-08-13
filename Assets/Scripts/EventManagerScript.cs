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
	public Button BackOfHouseButton;
	public Canvas kitchenCanvs;

	void Start()
	{
		customerScript = FindObjectOfType<CustomerScript>();
		if (inventoryCanvas.isActiveAndEnabled){
			inventoryCanvas.gameObject.SetActive (false);
		}if (dialoguePanel.activeInHierarchy){
			dialoguePanel.gameObject.SetActive (false);
		} openInventory = true;
		BackOfHouseButton.gameObject.SetActive (true);
	}
	public void OnNewCustomer()
	{
		GameObject customerInstance = Instantiate(customer, customerSpawnLocation);
		customerScript.CustomerA ();
		dialoguePanel.gameObject.SetActive (true);
		BackOfHouseButton.gameObject.SetActive (false);
	}

	public void OnCustomerFinished()
	{
		GameObject test = FindObjectOfType<GameObject> ();
		Destroy (test);
		dialoguePanel.gameObject.SetActive (false);
		BackOfHouseButton.gameObject.SetActive (true);
	}

	public void InventoryButtonClicked(){
		if (openInventory) {
			inventoryCanvas.gameObject.SetActive (true);
			customerButton.gameObject.SetActive (false);
			BackOfHouseButton.gameObject.SetActive (false);
			openInventory = false;
		} else if (!openInventory) {
			inventoryCanvas.gameObject.SetActive (false);
			customerButton.gameObject.SetActive (true);
			BackOfHouseButton.gameObject.SetActive (true);
			openInventory = true;
		}
	}
}
