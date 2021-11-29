using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bHouse: MonoBehaviour
{
    private bool onObject = false;

    public float lvlHouseB = 0;

    public float lvlRequest = 50;

    private Transform lvlUp;

    private void Start()
    {
        lvlUp = transform.Find("lvlUP");
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
        if (FindObjectOfType<Ressources_UI>().stone > lvlRequest && lvlHouseB < 10)
        {
            lvlUp.localPosition = new Vector3(0, -1, 0);
        }

        else
            lvlUp.localPosition = new Vector3(0, -3, 0);

        if (Input.GetMouseButtonDown(0) && onObject == true && FindObjectOfType<Ressources_UI>().stone > lvlRequest && lvlHouseB < 10)
        {
            lvlHouseB += 1;
            FindObjectOfType<Ressources_UI>().stone -= lvlRequest;
        }

        if (lvlHouseB == 0)
            {
                FindObjectOfType<wheatClass>().active = true;
                FindObjectOfType<house1>().active = false;
                FindObjectOfType<house2>().active = false;
                FindObjectOfType<house3>().active = false;
                FindObjectOfType<house4>().active = false;
                FindObjectOfType<house5>().active = false;
                FindObjectOfType<house6>().active = false;
                FindObjectOfType<house7>().active = false;
                FindObjectOfType<house8>().active = false;
                FindObjectOfType<house9>().active = false;
                FindObjectOfType<house10>().active = false;
            }
        if (lvlHouseB == 1)
            {
                lvlRequest = 100;
                FindObjectOfType<house1>().active = true;
            }

        if (lvlHouseB == 2)
            {
            lvlRequest = 150;
            FindObjectOfType<house2>().active = true;
            }

        if (lvlHouseB == 3)
            {
            lvlRequest = 200;
            FindObjectOfType<house3>().active = true;
            }

        if (lvlHouseB == 4)
            {
            lvlRequest =250;
            FindObjectOfType<house4>().active = true;
            }

        if (lvlHouseB == 5)
        {
            lvlRequest = 300;
            FindObjectOfType<house5>().active = true;
        }

        if (lvlHouseB == 6)
        {
            lvlRequest = 350;
            FindObjectOfType<house6>().active = true;
        }

        if (lvlHouseB == 7)
        {
            lvlRequest = 400;
            FindObjectOfType<house7>().active = true;
        }

        if (lvlHouseB == 8)
        {
            lvlRequest = 450;
            FindObjectOfType<house8>().active = true;
        }

        if (lvlHouseB == 9)
        {
            lvlRequest = 500;
            FindObjectOfType<house9>().active = true;
        }

        if (lvlHouseB == 10)
        {
            lvlRequest = 550;
            FindObjectOfType<house10>().active = true;
        }
    }
}
