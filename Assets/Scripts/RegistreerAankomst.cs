using UnityEngine;
using System.Collections;

public class RegistreerAankomst : MonoBehaviour {

    void OnTriggerEnter(Collider bezoekerBinnen)
    {
        Destroy(bezoekerBinnen.gameObject, 2f);

        if (gameObject.name == "Hoofdentree")
        {
            GameManagerScript.GameManagement.aantalEntree += 1;
        }
        else
        { 
            GameManagerScript.GameManagement.aantalDialyse += 1;
        }
    }
}
