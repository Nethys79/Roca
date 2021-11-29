using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house6 : MonoBehaviour
{
    private bool onObject = false;

    private bool checkcoolD = true;
    
    private bool wait = true;

    public bool active = false;

    public float mini = 20;
    public float max = 200;

    public float timer = 15;

    public float randomTime;
    public float randomDemand1;
    public float randomDemand2;

    private Transform FruitDemandH;
    private Transform BleDemandH;
    private Transform EauDemandH;

    [SerializeField] private Material myMaterialH;

    void Start()
    {
        FruitDemandH = transform.Find("Fruite");
        BleDemandH = transform.Find("Ble");
        EauDemandH = transform.Find("Eau");
    }

    void OnMouseOver()
        {
            onObject = true;
        }

    private void OnMouseExit()
        {
            onObject = false;
        }

    private void Update()
    {
    if (active == true){
        if (checkcoolD == true)
        {
            timer -= 1 * Time.deltaTime;
        }

        if (timer <= 0)
        {
            checkcoolD = false;
            randomTime = Random.Range(mini, max);
            wait = false;

            FruitDemandH.localPosition = new Vector3(.5f, -1, -.5f);
            BleDemandH.localPosition = new Vector3(0, -1, 0);
            EauDemandH.localPosition = new Vector3(-.5f, -1, .5f);

            FindObjectOfType<Reputation>().susRep();
        } 

        if (Input.GetMouseButtonDown(0) && onObject == true && checkcoolD == true && FindObjectOfType<Ressources_UI>().checkwheat == true && FindObjectOfType<Ressources_UI>().checkfruit == true && FindObjectOfType<Ressources_UI>().checkwater == true)
        {
            randomTime = Random.Range(mini,max);
            print(randomTime);
            checkcoolD = false;
            wait = false;

            FruitDemandH.localPosition = new Vector3(.5f, -1, -.5f);
            BleDemandH.localPosition = new Vector3(0, -1, 0);
            EauDemandH.localPosition = new Vector3(-.5f, -1, .5f);

            FindObjectOfType<Reputation>().addRep();

            if (randomDemand1 == 1)
            {
                print("nothing");
            }
            if (randomDemand1 == 2)
            {
                FindObjectOfType<Ressources_UI>().susWheat();
            }
            if (randomDemand1 == 3)
            {
                FindObjectOfType<Ressources_UI>().susFruit();
            }
            if (randomDemand1 == 4)
            {
                FindObjectOfType<Ressources_UI>().susWater();
            }

            if (randomDemand2 == 1)
            {
                print("nothing");
            }
            if (randomDemand2 == 2)
            {
                FindObjectOfType<Ressources_UI>().susWheat();
            }
            if (randomDemand2 == 3)
            {
                FindObjectOfType<Ressources_UI>().susFruit();
            }
            if (randomDemand2 == 4)
            {
                FindObjectOfType<Ressources_UI>().susWater();
            }
        }

        if (checkcoolD == false)
        {
            timer = 30;
            randomTime -= 1*Time.deltaTime;
            myMaterialH.color = Color.red;
        }
        
        if (randomTime < 0 && wait == false)
        {
            checkcoolD = true;
            myMaterialH.color = Color.green;
            demand();

        }
    }
    }

    void start()
    {
        
    }

    private void demand()
    {
        randomDemand1 = Random.Range(1,4);
        randomDemand2 = Random.Range(1,4);
        wait = true;
        
        FruitDemandH = transform.Find("Fruite");
        BleDemandH = transform.Find("Ble");
        EauDemandH = transform.Find("Eau");
        
        if(randomDemand1 == 1)
            {
                print("nothing");
            }
        if(randomDemand1 == 2)
            {
                BleDemandH.localPosition = new Vector3(0, 1, 0);
                print("Blé");
            }
        if(randomDemand1 == 3)
            {
                FruitDemandH.localPosition = new Vector3(.5f, 1, -.5f);
                print("Fruit");
            }
        if(randomDemand1 == 4)
            {
                EauDemandH.localPosition = new Vector3(-.5f, 1, .5f);
                print("Eau");
            }

        if(randomDemand2 == 1)
            {
                print("nothing");
            }
        if(randomDemand2 == 2)
            {
                BleDemandH.localPosition = new Vector3(0, 1, 0);
                print("Blé");
            }
        if(randomDemand2 == 3)
            {
                FruitDemandH.localPosition = new Vector3(.5f, 1, -.5f);
                print("Fruit");
            }
        if(randomDemand2 == 4)
            {
                EauDemandH.localPosition = new Vector3(-.5f, 1, .5f);
                print("Eau");
            }
    }
}
