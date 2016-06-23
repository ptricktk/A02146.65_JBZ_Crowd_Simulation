using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {

    public Material parkeerplaats;
    public Material ov;
    public Material kissenride;
    public Material fiets;
    public Material taxi;
    public Material parkeergarage;

    GameObject[] TargetsToGoTo;
    NavMeshAgent agent;
    Animator agentAnimator;
    int targetIndex = 0;

    // Use this for initialization
    void Awake () {
        agent = GetComponent<NavMeshAgent>();
        TargetsToGoTo = GameObject.FindGameObjectsWithTag("EindLocatie");
        agentAnimator = GetComponentInChildren<Animator>();

        if (GetStartBezoeker(gameObject.transform) == "OV-halte")
        {
            agent.GetComponentInChildren<Renderer>().material = ov;
            GameManagerScript.GameManagement.aantalBus += 1;
        }
        else if (GetStartBezoeker(gameObject.transform) == "Parkeerplaats")
        {
            agent.GetComponentInChildren<Renderer>().material = parkeerplaats;
            GameManagerScript.GameManagement.aantalParkeerPlaats += 1;
        }
        else if (GetStartBezoeker(gameObject.transform) == "Fietsenrek")
        {
            agent.GetComponentInChildren<Renderer>().material = fiets;
            GameManagerScript.GameManagement.aantalFiets += 1;
        }
        else if (GetStartBezoeker(gameObject.transform) == "Taxiplaats")
        {
            agent.GetComponentInChildren<Renderer>().material = taxi;
            GameManagerScript.GameManagement.aantalTaxi += 1;
        }
        else if (GetStartBezoeker(gameObject.transform) == "Parkeergarage")
        {
            agent.GetComponentInChildren<Renderer>().material = parkeergarage;
            GameManagerScript.GameManagement.aantalParkeerGarage += 1;
        }
        else if (GetStartBezoeker(gameObject.transform) == "KissAndRide")
        {
            agent.GetComponentInChildren<Renderer>().material = kissenride;
            GameManagerScript.GameManagement.aantalKissAndRide += 1;
        }


        


        targetIndex = Random.Range(0, TargetsToGoTo.Length);

        agent.avoidancePriority = (int)Random.Range(0f, 99f);
        agent.speed = Random.Range(2f, 5f);

        //if (TargetsToGoTo[targetIndex].name == "Hoofdentree")
        //{
        //    agent.GetComponentInChildren<Renderer>().material = hoofdentree;
        //}
        //else
        //    agent.GetComponentInChildren<Renderer>().material = dialyse;

        agentAnimator.SetBool("StartWalk", true);

    }
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(TargetsToGoTo[targetIndex].transform.position);

    }

    private string GetStartBezoeker(Transform startlocatie)
    {
        string startLocatieString = "onbekend"; 

        for (int i = 0; i < GameManagerScript.GameManagement.StartPosities.Length; i++)
        {
            if (startlocatie.position == GameManagerScript.GameManagement.StartPosities[i].transform.position)
            {
                startLocatieString = GameManagerScript.GameManagement.StartPosities[i].name;
            }
        }

        return startLocatieString;
        
    }

  
}
