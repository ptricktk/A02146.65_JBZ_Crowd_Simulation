using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

    public GameObject gm;

    void Awake()
    {
        if (GameManagerScript.GameManagement == null)
            Instantiate(gm);
    }

}
