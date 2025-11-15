using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PossibleUpgrades : MonoBehaviour
{
    public void DartMonkey(GameObject tower, string upgrade)
    {
        if (upgrade == "10")
        {
            tower.GetComponent<TowerBehavior>().pierce += 1;
        }
        else if (upgrade == "20")
        {
            tower.GetComponent<TowerBehavior>().pierce += 2;
        }
        else if (upgrade == "30")
        {
            tower.GetComponent<TowerBehavior>().dmg = 2;
            tower.GetComponent<TowerBehavior>().pierce = 19;
        }
        else if (upgrade == "40")
        {
            tower.GetComponent<TowerBehavior>().dmg = 2;
            tower.GetComponent<TowerBehavior>().pierce = 61;
tower.GetComponent<TowerBehavior>().fireRate = 1;
            // TODO split projectiles
        }
        else if (upgrade == "50")
        {
            tower.GetComponent<TowerBehavior>().dmg = 3;
            tower.GetComponent<TowerBehavior>().pierce = 100;
            tower.GetComponent<TowerBehavior>().fireRate = 0.7f;
            // TODO more splits
        } 
        else if(upgrade =="01")
        {
            tower.GetComponent<TowerBehacior>9.range +=8f;
       
        }
        else if(upgrade == "02")
        {
            tower.GetComponent<TowerBehacior>9.range +=8f;
             // Todo Camo detection
        }
        else if(upgrade =="03")
        {
            tower.GetComponent<TowerBehacior>9.dmg  +=3f;
            tower.GetComponent<TowerBehacior>9.pierce +=3f;
        }
        else if(upgrade =="04")
        {
            tower.GetComponent<TowerBehacior>9.dmg +=6f;

        }

    }
}