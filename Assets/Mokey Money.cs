using UnityEngine;
using TMPro;

public class MokeyMoney : MonoBehaviour
{
    public int money;
    public TMP_Text moneyText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       moneyText.text = "$" + money.ToString();        
    }
}
