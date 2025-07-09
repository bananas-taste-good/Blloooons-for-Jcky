using UnityEngine;
using TMPro
public class Lives : MonoBehaviour
{
    public int lives;
    public TMP_Text livesText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       livesText.text = lives.ToString();            

}
