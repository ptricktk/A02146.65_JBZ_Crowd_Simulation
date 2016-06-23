using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetStartBehaviour : MonoBehaviour {

    public Text txtParkeerGarage;
    public Text txtTaxi;
    public Text txtFiets;
    public Text txtBus;
    public Text txtParkeerPlaats;
    public Text txtKissAndRide;

	
    public void StartSimulatie()
    {
        SetBezoekersAantallen();
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    void SetBezoekersAantallen()
    {
        if (txtParkeerGarage.text == null)
            GameManagerScript.GameManagement.initialBezoekerParkeerGarage = 1;
        else
            GameManagerScript.GameManagement.initialBezoekerParkeerGarage = int.Parse(txtParkeerGarage.text);

        if (txtTaxi.text == null)
            GameManagerScript.GameManagement.initialBezoekerTaxi = 1;
        else
            GameManagerScript.GameManagement.initialBezoekerTaxi = int.Parse(txtTaxi.text);

        if (txtFiets.text == null)
            GameManagerScript.GameManagement.initialBezoekerFiets = 1;
        else
            GameManagerScript.GameManagement.initialBezoekerFiets = int.Parse(txtFiets.text);

        if (txtBus.text == null)
            GameManagerScript.GameManagement.initialBezoekerBus = 1;
        else
            GameManagerScript.GameManagement.initialBezoekerBus = int.Parse(txtBus.text);

        if (txtTaxi.text == null)
            GameManagerScript.GameManagement.initialBezoekerParkeerPlaats = 1;
        else
            GameManagerScript.GameManagement.initialBezoekerParkeerPlaats = int.Parse(txtTaxi.text);

        if (txtKissAndRide.text == null)
            GameManagerScript.GameManagement.initialBezoekerKissAndRide = 1;
        else
            GameManagerScript.GameManagement.initialBezoekerKissAndRide = int.Parse(txtKissAndRide.text);
    }
}
