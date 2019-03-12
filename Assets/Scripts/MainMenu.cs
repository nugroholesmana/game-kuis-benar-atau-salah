using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public GameObject ObjPanel;
	public GameObject PanelKuisKita;

	Animator AnimatorPanelKuisKita;

	public static GameObject ClonePanelKuisKita;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonClickPanelKuisKita(){
		ClonePanelKuisKita = Instantiate (PanelKuisKita);
		ClonePanelKuisKita.transform.SetParent (ObjPanel.transform,false);			
	}

	public void ButtonClickClosePanelKuisKita(){
		Destroy (ClonePanelKuisKita);
	}
}
