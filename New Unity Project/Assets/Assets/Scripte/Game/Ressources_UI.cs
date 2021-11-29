using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ressources_UI : MonoBehaviour
{
    public float wheat = 100;
    public float wheatMax = 1000;

    public float fruit = 100;
    public float fruitMax = 1000;

    public float water = 100;
    public float waterMax = 750;

    public float wood = 50;
    public float woodMax = 500;

    public float stone = 50;
    public float stoneMax = 500;

    public float metal = 0;
    public float metalMax = 100;

    public bool checkwheat = true;
    public bool checkfruit = true;
    public bool checkwater = true;
    public bool checkwood = true;
    public bool checkstone = true;
    public bool checkmetal = true;
    
    private TextMeshProUGUI textMesH;

    void start()
    {
         textMesH = GetComponent<TextMeshProUGUI>();
    }

    public void addWheat()
    {
        if (wheat < wheatMax)
        {
            wheat += 5;
        }
       
    }

    public void addFruit()
    {
        if (fruit < fruitMax)
        {
            fruit += 5;
        }
    }

    public void addWater()
    {
        if (water < waterMax)
        {
            water += 5;
        }
    }

    public void addWood()
    {
        if (wood < woodMax)
        {
            wood += 5;
        }
    }

    public void addStone()
    {
        if (stone < stoneMax)
        {
            stone += 5;
        }
    }

    public void addMetal()
    {
        if (metal < metalMax)
        {
            metal += 5;
        }
    }



    public void susWheat()
    {
        if (wheat > 10)
        {
            wheat -= 10;
        }
    }

    public void susFruit()
    {
        if (fruit > 10)
        {
            fruit -= 10;
        }
    }

    public void susWater()
    {
        if (water > 01)
        {
            water -= 10;
        }
    }

    public void susWood()
    {
        if (wood > 01)
        {
            wood -= 10;
        }
    }

    public void susStone()
    {
        if (stone < 10)
        {
            stone -= 10;
        }
    }

    public void susMetal()
    {
        if (metal < 5)
        {
            metal -= 5;
        }
    }

    public void Update()
    {
        if (wheat > wheatMax)
        {
            wheat = wheatMax;
        }

        if (fruit > fruitMax)
        {
            fruit = fruitMax;
        }

        if (water > waterMax)
        {
           water = waterMax;
        }

        if (wood > woodMax)
        {
            wood = woodMax;
        }

        if (stone > stoneMax)
        {
            stone = stoneMax;
        }

        if (metal > metalMax)
        {
            metal = metalMax;
        }



        if (wheat < 10)
        {
            checkwheat = false;
        }

        if (fruit < 10)
        {
            checkfruit = false;
        }

        if (water < 10)
        {
            checkwater = false;
        }

        if (wood < 10)
        {
            checkwood = false;
        }

        if (stone < 10)
        {
            checkstone = false;
        }

        if (metal < 5)
        {
            checkmetal = false;
        }

        else
            checkwheat = true;
            checkfruit = true;
            checkwater = true;
            checkwood = true;
            checkstone = true;
            checkmetal = true;
    }
}
