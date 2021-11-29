using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chateau : MonoBehaviour
{
    private bool onObject = false;

    private bool checkcoolD = true;
    
    private bool wait = true;

    public bool active = true;

    public float mini = 20;
    public float max = 200;

    public float timer = 15;

    public float randomTime;
    public float randomDemand1;
    public float randomDemand2;

    private Transform FruitDemandC;
    private Transform BleDemandC;
    private Transform EauDemandC;
    private Transform MetalDemandC;

    [SerializeField] private Material myMaterialH;

    void Start()
    {
        FruitDemandC = transform.Find("Fruite_C");
        BleDemandC = transform.Find("Ble_C");
        EauDemandC = transform.Find("Eau_C");
        MetalDemandC = transform.Find("Metal_C");
    }

    void OnMouseOver()
        {
            //print(gameObject.name);
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
                    //print(randomTime);
                    wait = false;
        
                    FruitDemandC.localPosition = new Vector3(.5f, -1.5f, .5f);
                    BleDemandC.localPosition = new Vector3(-0.5f, -1.5f, -0.5f);
                    EauDemandC.localPosition = new Vector3(-.5f, -1.5f, .5f);
                    MetalDemandC.localPosition = new Vector3(.5f, -1.5f, -.5f);
        
                    FindObjectOfType<Reputation>().susRep();
        
                } 
        
                if (Input.GetMouseButtonDown(0) && onObject == true && checkcoolD == true && FindObjectOfType<Ressources_UI>().checkwheat == true && FindObjectOfType<Ressources_UI>().checkfruit == true && FindObjectOfType<Ressources_UI>().checkwater == true && FindObjectOfType<Ressources_UI>().checkmetal == true)
                {
                    randomTime = Random.Range(mini,max);
                    print(randomTime);
                    checkcoolD = false;
                    wait = false;
        
                    FruitDemandC.localPosition = new Vector3(.5f, -1.5f, .5f);
                    BleDemandC.localPosition = new Vector3(-0.5f, -1.5f, -0.5f);
                    EauDemandC.localPosition = new Vector3(-.5f, -1.5f, .5f);
                    MetalDemandC.localPosition = new Vector3(.5f, -1.5f, -.5f);
        
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
                    if (randomDemand1 == 5)
                    {
                        FindObjectOfType<Ressources_UI>().susMetal();
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
                    if (randomDemand2 == 5)
                    {
                        FindObjectOfType<Ressources_UI>().susMetal();
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

    private void demand()
    {
        randomDemand1 = Random.Range(1,5);
        randomDemand2 = Random.Range(1,5);
        wait = true;
        
        FruitDemandC = transform.Find("Fruite_C");
        BleDemandC = transform.Find("Ble_C");
        EauDemandC = transform.Find("Eau_C");
        MetalDemandC = transform.Find("Metal_C");

        if (randomDemand1 == 1)
            {
                print("nothing");
            }
        if(randomDemand1 == 2)
            {
                BleDemandC.localPosition = new Vector3(-0.5f, 1, -0.5f);
                print("Blé");
            }
        if(randomDemand1 == 3)
            {
                FruitDemandC.localPosition = new Vector3(.5f, 1, .5f);
                print("Fruit");
            }
        if(randomDemand1 == 4)
            {
                EauDemandC.localPosition = new Vector3(-.5f, 1, .5f);
                print("Eau");
            }
        if (randomDemand1 == 5)
            {
                MetalDemandC.localPosition = new Vector3(.5f, 1, -.5f);
                print("Metal");
            }

        if (randomDemand2 == 1)
            {
                print("nothing");
            }
        if(randomDemand2 == 2)
            {
                BleDemandC.localPosition = new Vector3(-0.5f, 1, -0.5f);
                print("Blé");
            }
        if(randomDemand2 == 3)
            {
                FruitDemandC.localPosition = new Vector3(.5f, 1, .5f);
                print("Fruit");
            }
        if(randomDemand2 == 4)
            {
                EauDemandC.localPosition = new Vector3(-.5f, 1, .5f);
                print("Eau");
            }
        if (randomDemand2 == 5)
            {
                MetalDemandC.localPosition = new Vector3(.5f, 1, -.5f);
                print("Metal");
            }
    }
}