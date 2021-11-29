using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boisField : MonoBehaviour
{
    private bool onObject = false;

    public float lvlfieldB = 0;

    public float lvlRequest1 = 50;
    public float lvlRequest2 = 10;

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
        if (FindObjectOfType<Ressources_UI>().stone > lvlRequest1 && FindObjectOfType<Ressources_UI>().metal > lvlRequest1 && lvlfieldB < 5)
        {
            lvlUp.localPosition = new Vector3(0, -1, 0);
        }

        else
            lvlUp.localPosition = new Vector3(0, -3, 0);

        if (Input.GetMouseButtonDown(0) && onObject == true && FindObjectOfType<Ressources_UI>().stone > lvlRequest1 && FindObjectOfType<Ressources_UI>().metal > lvlRequest1 && lvlfieldB < 5)
        {
            lvlfieldB += 1;
            FindObjectOfType<Ressources_UI>().metal -= lvlRequest1;
        }

        if (lvlfieldB == 0)
            {
                FindObjectOfType<woodClass>().active = true;
                FindObjectOfType<woodClass1>().active = false;
                FindObjectOfType<woodClass2>().active = false;
                FindObjectOfType<woodClass3>().active = false;
                FindObjectOfType<woodClass4>().active = false;
                FindObjectOfType<woodClass5>().active = false;
            }
        if (lvlfieldB == 1)
            {
                lvlRequest1 = 60;
                lvlRequest2 = 15;
                FindObjectOfType<woodClass1>().active = true;
            }

        if (lvlfieldB == 2)
            {
                lvlRequest1 = 70;
                lvlRequest2 = 20;
                FindObjectOfType<woodClass2>().active = true;
            }

        if (lvlfieldB == 3)
            {
                lvlRequest1 = 80;
                lvlRequest2 = 25;
                FindObjectOfType<woodClass3>().active = true;
            }

        if (lvlfieldB == 4)
            {
                lvlRequest1 = 90;
                lvlRequest2 = 30;
                FindObjectOfType<woodClass4>().active = true;
            }

        if (lvlfieldB == 5)
        {
                lvlRequest1 = 100;
                lvlRequest2 = 35;
                FindObjectOfType<woodClass5>().active = true;
        }
    }
}
