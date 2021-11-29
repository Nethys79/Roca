using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bSanctuaire: MonoBehaviour
{
    private bool onObject = false;

    public float lvlHouseB = 0;

    public float lvlRequest1 = 75;
    public float lvlRequest2 = 50;

    private Transform lvlUp;

    private void Start()
    {
        lvlUp = transform.Find("lvlUp");
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

    void Update()
    {
        if (FindObjectOfType<Ressources_UI>().stone > lvlRequest1 && FindObjectOfType<Ressources_UI>().metal > lvlRequest2 && lvlHouseB < 1)
        {
            lvlUp.localPosition = new Vector3(0, -1, 0);
        }

        else
            lvlUp.localPosition = new Vector3(0, -3, 0);

        if (Input.GetMouseButtonDown(0) && onObject == true && FindObjectOfType<Ressources_UI>().stone > lvlRequest1 && FindObjectOfType<Ressources_UI>().metal > lvlRequest2 && lvlHouseB < 1)
            {
                lvlHouseB += 1;
                FindObjectOfType<Ressources_UI>().stone -= lvlRequest1;
                FindObjectOfType<Ressources_UI>().metal -= lvlRequest2;
            }

        if (lvlHouseB == 0)
            {
                FindObjectOfType<sanctuaire>().active = true;
                FindObjectOfType<sanctuaire1>().active = false;
            }
        if (lvlHouseB == 1)
            {
                lvlRequest1 = 125;
                lvlRequest1 = 75;
                FindObjectOfType<sanctuaire1>().active = true;
            }
    }
}
