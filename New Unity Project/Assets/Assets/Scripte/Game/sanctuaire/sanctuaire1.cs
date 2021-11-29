using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanctuaire1 : MonoBehaviour
{
    private bool onObject = false;

    private bool checkcoolD = true;
    
    private bool wait = true;

    public bool active = true;

    public float mini = 100;
    public float max = 360;

    public float timer = 60;

    public float randomTime;
    public float randomDemand1;
    

    [SerializeField] private Material myMaterial;

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
                print(randomTime);
                wait = false;
    
                FindObjectOfType<Reputation>().susRep();
            } 
    
            if (Input.GetMouseButtonDown(0) && onObject == true && checkcoolD == true && FindObjectOfType<Ressources_UI>().checkwheat == true && FindObjectOfType<Ressources_UI>().checkfruit == true && FindObjectOfType<Ressources_UI>().checkwater == true)
            {
                randomTime = Random.Range(mini,max);
                print(randomTime);
                checkcoolD = false;
                wait = false;
    
                FindObjectOfType<Reputation>().addRep();
    
                if (randomDemand1 == 1)
                {
                    print("nothing");
                }
                if (randomDemand1 == 2)
                {
                    FindObjectOfType<Ressources_UI>().susWheat();
                    FindObjectOfType<Ressources_UI>().susWheat();
                    FindObjectOfType<Ressources_UI>().susWheat();
                    FindObjectOfType<Ressources_UI>().susFruit();
                    FindObjectOfType<Ressources_UI>().susWater();
                    FindObjectOfType<Ressources_UI>().susWater();
                }
                if (randomDemand1 == 3)
                {
                    FindObjectOfType<Ressources_UI>().susFruit();
                    FindObjectOfType<Ressources_UI>().susWheat();
                    FindObjectOfType<Ressources_UI>().susWheat();
                    FindObjectOfType<Ressources_UI>().susFruit();
                    FindObjectOfType<Ressources_UI>().susFruit();
                    FindObjectOfType<Ressources_UI>().susWater();
                }
                if (randomDemand1 == 4)
                {
                    FindObjectOfType<Ressources_UI>().susWater();
                    FindObjectOfType<Ressources_UI>().susFruit();
                    FindObjectOfType<Ressources_UI>().susWater();
                    FindObjectOfType<Ressources_UI>().susWater();
                    FindObjectOfType<Ressources_UI>().susWheat();
                }
            }
    
            if (checkcoolD == false)
            {
                timer = 30;
                randomTime -= 1*Time.deltaTime;
                myMaterial.color = Color.red;
            }
            
            if (randomTime < 0 && wait == false)
            {
                checkcoolD = true;
                myMaterial.color = Color.green;
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
        wait = true;
        
        if(randomDemand1 == 1)
            {
                print("nothing");
            }
        if(randomDemand1 == 2)
            {
                print("Cérémonie Blé");
            }
        if(randomDemand1 == 3)
            {
                print("Cérémonie Fruit");
            }
        if(randomDemand1 == 4)
            {
                print("Cérémonie Eau");
            }
    }
}
