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
    Text StartKissAndRide;

    // Use this for initialization
    void Awake() {
        
        bezoekersHoofdentree = GetComponentsInChildren<Text>()[0];

        startParkeergarage = GetComponentsInChildren<Text>()[1];
        startTaxi = GetComponentsInChildren<Text>()[2];
        startFietsenstalling = GetComponentsInChildren<Text>()[3];
        startBushalte = GetComponentsInChildren<Text>()[4];
        startParkeerplaats = GetComponentsInChildren<Text>()[5];
        StartKissAndRide = GetComponentsInChildren<Text>()[6];
    }
	
	// Update is called once per frame
	void Update () {
        bezoekersHoofdentree.text = "Bezoekers Hoofdentree: " + GameManagerScript.GameManagement.aantalEntree;

        startParkeergarage.text = "Parkeergarage: " + GameManagerScript.GameManagement.aantalParkeerGarage;
        startTaxi.text = "Taxi standplaats: " + GameManagerScript.GameManagement.aantalTaxi;
        startFietsenstalling.text = "Fietsenstalling: " + GameManagerScript.GameManagement.aantalFiets;
        startBushalte.text = "Bushalte: " + GameManagerScript.GameManagement.aantalBus;
        startParkeerplaats.text = "Parkeerplaats: " + GameManagerScript.GameManagement.aantalParkeerPlaats;
        StartKissAndRide.text = "Kiss & Ride: " + GameManagerScript.GameManagement.aantalKissAndRide;
    }
}
