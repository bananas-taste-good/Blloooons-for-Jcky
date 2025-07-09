using UnityEngine;

public class Buyingtowers : MonoBehaviour
    public MonkeyMoney money;
{
    public void buyMonkey(Tower toBuy)
    { 
        money.money -= toBuy.cost;
        Debud.log("Successfully bought " + toBuy.TowerName);
    } 
    public void monkeyCheck(int index)
    (
        buyMonkey(); //ToDo
    )
} 

