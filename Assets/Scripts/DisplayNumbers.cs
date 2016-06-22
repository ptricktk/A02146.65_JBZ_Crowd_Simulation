using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayNumbers : MonoBehaviour {

    Text bezoekersHoofdentree;
    Text bezoekersDialyse;

    Text startParkeerplaats;
    Text startTaxi;
    Text startFietsenstalling;
    Text startBushalte;
    Text startParkeergarage;


    // Use this for initialization
    void Awake() {
        
        bezoekersHoofdentree = GetComponentsInChildren<Text>()[0];
        bezoekersDialyse = GetComponentsInChildren<Text>()[1];

        startParkeergarage = GetComponentsInChildren<Text>()[2];
        startTaxi = GetComponentsInChildren<Text>()[3];
        startFietsenstalling = GetComponentsInChildren<Text>()[4];
        startBushalte = GetComponentsInChildren<Text>()[5];
        startParkeerplaats = GetComponentsInChildren<Text>()[6];

    }
	
	// Update is called once per frame
	void Update () {
        bezoekersDialyse.text = "Bezoekers Dialyse: " + GameManagerScript.GameManagement.aantalDialyse;
        bezoekersHoofdentree.text = "Bezoekers Hoofdentree: " + GameManagerScript.GameManagement.aantalEntree;

        startParkeergarage.text = "Uit parkeergarage: " + GameManagerScript.GameManagement.aantalParkeerGarage;
        startTaxi.text = "Uit taxistandplaats: " + GameManagerScript.GameManagement.aantalTaxi;
        startFietsenstalling.text = "Uit fietsenstalling: " + GameManagerScript.GameManagement.aantalFiets;
        startBushalte.text = "Uit bushalte: " + GameManagerScript.GameManagement.aantalBus;
        startParkeerplaats.text = "Uit parkeerplaats: " + GameManagerScript.GameManagement.aantalParkeerPlaats;
    }
}
