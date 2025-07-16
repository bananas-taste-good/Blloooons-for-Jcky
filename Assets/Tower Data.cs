using UnityEngine;

public class TowerData : MonoBehaviour
{
    public Tower[] towers = new Tower[30];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        towers[0] = new Tower(170, "Dart Monkey");
        towers[1] = new Tower(340, "Druid");
        towers[2] = new Tower(340, "Buccaneer");
        towers[4] = new Tower(1275, "Helicopter");
        towers[5] = new Tower(2125, "Super Monkey");
        towers[6] = new Tower(375, "Mer Monkey");
        towers[7] = new Tower(295, "Ninja");
        towers[8] = new Tower(300, "sniper");
        towers[9] = new Tower(210, "Wizard");
        towers[10] = new Tower(720, "Dartling Gunner");
        towers[11] = new Tower(680, "Plane");
        towers[12] = new Tower(1020, "Village");
        towers[13] = new Tower(275, "Submerine");
        towers[14] = new Tower(320, "Cannon");
        towers[15] = new Tower(2500, "Daragon");
        towers[16] = new Tower(3000, "Bagetaer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
