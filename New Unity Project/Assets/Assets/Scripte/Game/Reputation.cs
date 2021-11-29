using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reputation : MonoBehaviour
{
    public float repMini = 0;
    public float rep = 50;
    public float repMax = 100;

    private Transform BlackB;

    Vector3 BlackP;

    void Start()
    {
        
        BlackB = transform.Find("weshJeBouge");
    }

    public void addRep()
    {
        if (rep < repMax)
        {
            rep += 5;
            BlackP = transform.position;
            BlackP.x -= 1f;
            transform.position = BlackP;
           //BlackB.localPosition = new Vector3(transform.position.x +=0.1f, 1f, 0);
        }
    }

    public void susRep()
    {
        if (rep > repMini)
        {
            rep -= 5;
            BlackP = transform.position;
            BlackP.x += 1f;
            transform.position = BlackP;
            //BlackB.localPosition = new Vector3(0.1f, 1f, 0);
        }
    }
}
