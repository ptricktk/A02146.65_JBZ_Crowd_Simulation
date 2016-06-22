using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameManagerScript : MonoBehaviour {

    public static GameManagerScript GameManagement = null;

    public int aantalDialyse = 0;
    public int aantalEntree = 0;

    public int aantalParkeerGarage = 0;
    public int aantalTaxi = 0;
    public int aantalFiets = 0;
    public int aantalBus = 0;
    public int aantalParkeerPlaats = 0;
    public int aantalKissAndRide = 0;


    public GameObject[] StartPosities;
    
    public GameObject bezoeker;

    GameObject[] fixedStartPosities;
    int bezoekersCounter = 0;

    void Awake()
    {
        if (GameManagement == null)
        {
            GameManagement = this;
        }
        else if (GameManagement != this)
        {
            Destroy(gameObject);
        }


        DontDestroyOnLoad(gameObject);
        StartPosities = GameObject.FindGameObjectsWithTag("StartLocatie");
        
        //InvokeRepeating("SpawnRandomBezoekers", 2.0f, 1.0f);

        CreateBezoekersFlow();
        InvokeRepeating("SpawnFixedBezoekers", 2.0f, 1.0f);

    }

    void SpawnFixedBezoekers()
    {
            Instantiate(bezoeker, fixedStartPosities[bezoekersCounter].transform.position, fixedStartPosities[bezoekersCounter].transform.rotation);

        if (fixedStartPosities[bezoekersCounter].name == "OV-halte")
        {
            aantalBus += 1;
        } 
        else if (fixedStartPosities[bezoekersCounter].name == "Parkeerplaats")
        {
            aantalParkeerPlaats += 1;
        }
        else if (fixedStartPosities[bezoekersCounter].name == "Fietsenrek")
        {
            aantalFiets += 1;
        }
        else if (fixedStartPosities[bezoekersCounter].name == "Taxiplaats")
        {
            aantalTaxi += 1;
        }
        else if (fixedStartPosities[bezoekersCounter].name == "Parkeergarage")
        {
            aantalParkeerGarage += 1;
        }
        else if (fixedStartPosities[bezoekersCounter].name == "KissAndRide")
        {
            aantalKissAndRide += 1;
        }
        bezoekersCounter++;

        


        if (bezoekersCounter == fixedStartPosities.Length)
        {
            CreateBezoekersFlow();
            bezoekersCounter = 0;
        }
    }

    void SpawnRandomBezoekers()
    {
        int spawnLocationIndex = Random.Range(0, StartPosities.Length);

        if (spawnLocationIndex == 0)
            aantalKissAndRide += 1;
        else if (spawnLocationIndex == 1)
            aantalBus += 1;
        else if (spawnLocationIndex == 2)
            aantalFiets += 1;
        else if (spawnLocationIndex == 3)
            aantalParkeerPlaats += 1;
        else if (spawnLocationIndex == 4)
            aantalTaxi += 1;
        else
        {
            aantalParkeerGarage += 1;
        }

        Instantiate(bezoeker, StartPosities[spawnLocationIndex].transform.position, StartPosities[spawnLocationIndex].transform.rotation);
    }

    void CreateBezoekersFlow()
    {
        int bezoekersAantalKissAndRide = 1;
        int bezoekersAantalOV = 2;
        int bezoekersAantalFiets = 3;
        int bezoekersAantalParkeerplaats = 10;
        int bezoekersAantalTaxi = 2;
        int bezoekersAantalParkeergarage = 20;

        int totaalAantalFixedBezoekers = (bezoekersAantalKissAndRide + bezoekersAantalOV + bezoekersAantalFiets + bezoekersAantalParkeerplaats + bezoekersAantalTaxi + bezoekersAantalParkeergarage);
        int arrayCounter = 0;

        GameObject[] fixedBezoekers = new GameObject[totaalAantalFixedBezoekers];

        for (int i = 0; i < bezoekersAantalKissAndRide; i++)
        {
            fixedBezoekers[arrayCounter]= StartPosities[0];
            arrayCounter++;
        }
        for (int i = 0; i < bezoekersAantalOV; i++)
        {
            fixedBezoekers[arrayCounter] = StartPosities[1];
            arrayCounter++;
        }

        for (int i = 0; i < bezoekersAantalFiets; i++)
        {
            fixedBezoekers[arrayCounter] = StartPosities[2];
            arrayCounter++;
        }

        for (int i = 0; i < bezoekersAantalParkeerplaats; i++)
        {
            fixedBezoekers[arrayCounter] = StartPosities[3];
            arrayCounter++;
        }

        for (int i = 0; i < bezoekersAantalTaxi; i++)
        {
            fixedBezoekers[arrayCounter] = StartPosities[4];
            arrayCounter++;
        }
        for (int i = 0; i < bezoekersAantalParkeergarage; i++)
        {
            fixedBezoekers[arrayCounter] = StartPosities[5];
            arrayCounter++;
        }

        System.Random rnd = new System.Random();
        fixedStartPosities = fixedBezoekers.OrderBy(x => rnd.Next()).ToArray();
        
            }



}
