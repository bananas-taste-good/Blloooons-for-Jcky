using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PossibleUpgrades : MonoBehaviour
{
    public void DartMonkey(GameObject tower, string upgrade)
    {
        if (upgrade == "10")
        {
            tower.GetComponent<Tower_Behavior>().pierce += 1;
        }
        else if (upgrade == "20")
        {
            tower.GetComponent<Tower_Behavior>().pierce += 2;
        }
        else if (upgrade == "30")
        {
            tower.GetComponent<Tower_Behavior>().dmg = 2;
            tower.GetComponent<Tower_Behavior>().pierce = 19;
        }
        else if (upgrade == "40")
        {
            tower.GetComponent<Tower_Behavior>().dmg = 2;
            tower.GetComponent<Tower_Behavior>().pierce = 61;
tower.GetComponent<Tower_Behavior>().fireRate = 1;
            // TODO split projectiles
        }
        else if (upgrade == "50")
        {
            tower.GetComponent<Tower_Behavior>().dmg = 3;
            tower.GetComponent<Tower_Behavior>().pierce = 100;
            tower.GetComponent<Tower_Behavior>().fireRate = 0.7f;
            // TODO more splits
        } 
        else if(upgrade =="01")
        {
            tower.GetComponent<Tower_Behavior>().range +=8f;
       
        }
        else if(upgrade == "02")
        {
            tower.GetComponent<Tower_Behavior>().range +=8f;
             // Todo Camo detection
        }
        else if(upgrade =="03")
        {
            tower.GetComponent<Tower_Behavior>().dmg  +=3f;
            tower.GetComponent<Tower_Behavior>().pierce +=3;
        }
        else if(upgrade =="04")
        {
            tower.GetComponent<Tower_Behavior>().dmg +=6f;

        }

    }
}