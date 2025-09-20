using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject[] panels;

    
    public void exitTheGame()
    {
        Application.Quit();
    }
    public void openMenu(int index)
    {
        for(int i = 0; i < 5; i++)
        {
            if(i == index)
            {
                panels[i].gameObject.SetActive(true);
            }
            else
            {
                panels[i].gameObject.SetActive(false);
            }
        }
    }
}