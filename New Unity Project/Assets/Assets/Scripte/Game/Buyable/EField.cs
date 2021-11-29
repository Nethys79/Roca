using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EField : MonoBehaviour
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
                FindObjectOfType<waterClass>().active = true;
                FindObjectOfType<waterClass1>().active = false;
                FindObjectOfType<waterClass2>().active = false;
                FindObjectOfType<waterClass3>().active = false;
                FindObjectOfType<waterClass4>().active = false;
                FindObjectOfType<waterClass5>().active = false;
            }
        if (lvlfieldB == 1)
            {
                lvlRequest = 150;
                FindObjectOfType<waterClass1>().active = true;
            }

        if (lvlfieldB == 2)
            {
            lvlRequest = 200;
            FindObjectOfType<waterClass2>().active = true;
            }

        if (lvlfieldB == 3)
            {
            lvlRequest = 250;
            FindObjectOfType<waterClass3>().active = true;
            }

        if (lvlfieldB == 4)
            {
            lvlRequest = 300;
            FindObjectOfType<waterClass4>().active = true;
            }

        if (lvlfieldB == 5)
        {
            lvlRequest = 350;
            FindObjectOfType<waterClass5>().active = true;
        }
    }
}
