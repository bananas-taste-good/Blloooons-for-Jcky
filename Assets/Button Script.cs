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
        panels[index].gameObject.SetActive(true);
    }
}
