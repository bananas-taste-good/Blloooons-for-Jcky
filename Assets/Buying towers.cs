using UnityEngine;

public class Buyingtowers : MonoBehaviour

{
    public MokeyMoney money;
    public TowerData towerData;    
    public void buyMonkey(Tower toBuy)
    { 
        if(money.money >=toBuy.cost){
        money.money -= toBuy.cost;
        Debug.Log("Successfully bought " + toBuy.TowerName);
    }   
    }
    public void monkeyCheck(int index)
    {
        Debug.Log(index);
        buyMonkey(towerData.towers[index]);
    }
} 

