using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheatClass : MonoBehaviour
{
    private bool onObject = false;

    public bool active = true;

    private bool checkcoolD = true;
    private float time = 0f;

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
        if (Input.GetMouseButtonDown(0) && onObject == true && checkcoolD == true)
        {
            //Debug.Log("sa clique");
            FindObjectOfType<Ressources_UI>().addWheat();
            checkcoolD = false;
            myMaterial.color = Color.red;
        }

        if (checkcoolD == false)
        {
            time += 1*Time.deltaTime;
        }

        if (time > 10)
        {
            myMaterial.color = Color.yellow;
        }

        if (time > 20)
        {
            checkcoolD = true;
            time = 0;
            myMaterial.color = Color.green;
        }
    }
}
