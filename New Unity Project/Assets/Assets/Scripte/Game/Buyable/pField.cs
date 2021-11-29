using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pField : MonoBehaviour
{
    private bool onObject = false;

    public float lvlfieldB = 0;

    public float lvlRequest = 100;

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
        if (FindObjectOfType<Ressources_UI>().wood > lvlRequest && lvlfieldB < 5)
        {
            lvlUp.localPosition = new Vector3(0, -1, 0);
        }

        else
            lvlUp.localPosition = new Vector3(0, -3, 0);

        if (Input.GetMouseButtonDown(0) && onObject == true && FindObjectOfType<Ressources_UI>().wood > lvlRequest && lvlfieldB < 5)
        {
            lvlfieldB += 1;
            FindObjectOfType<Ressources_UI>().wood -= lvlRequest;
        }

        if (lvlfieldB == 0)
            {
                FindObjectOfType<stoneClass>().active = true;
                FindObjectOfType<stoneClass1>().active = false;
                FindObjectOfType<stoneClass2>().active = false;
                FindObjectOfType<stoneClass3>().active = false;
                FindObjectOfType<stoneClass4>().active = false;
                FindObjectOfType<stoneClass5>().active = false;
            }
        if (lvlfieldB == 1)
            {
                lvlRequest = 150;
                FindObjectOfType<stoneClass1>().active = true;
            }

        if (lvlfieldB == 2)
            {
            lvlRequest = 200;
            FindObjectOfType<stoneClass2>().active = true;
            }

        if (lvlfieldB == 3)
            {
            lvlRequest = 250;
            FindObjectOfType<stoneClass3>().active = true;
            }

        if (lvlfieldB == 4)
            {
            lvlRequest = 300;
            FindObjectOfType<stoneClass4>().active = true;
            }

        if (lvlfieldB == 5)
        {
            lvlRequest = 350;
            FindObjectOfType<stoneClass5>().active = true;
        }
    }
}
