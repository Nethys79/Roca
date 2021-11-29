using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fField : MonoBehaviour
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
                FindObjectOfType<fruitClass>().active = true;
                FindObjectOfType<fruitClass1>().active = false;
                FindObjectOfType<fruitClass2>().active = false;
                FindObjectOfType<fruitClass3>().active = false;
                FindObjectOfType<fruitClass4>().active = false;
                FindObjectOfType<fruitClass5>().active = false;
            }
        if (lvlfieldB == 1)
            {
                lvlRequest = 150;
                FindObjectOfType<fruitClass1>().active = true;
            }

        if (lvlfieldB == 2)
            {
            lvlRequest = 200;
            FindObjectOfType<fruitClass2>().active = true;
            }

        if (lvlfieldB == 3)
            {
            lvlRequest = 250;
            FindObjectOfType<fruitClass3>().active = true;
            }

        if (lvlfieldB == 4)
            {
            lvlRequest = 300;
            FindObjectOfType<fruitClass4>().active = true;
            }

        if (lvlfieldB == 5)
        {
            lvlRequest = 350;
            FindObjectOfType<fruitClass5>().active = true;
        }
    }
}
