using UnityEngine;

public class Hearts : MonoBehaviour
{
    public int health;

    public int maxHealth;

    public void takeDmg(int dmg)
    {
        health -= dmg;

    }

    public void die()
    {
        Destroy(gameObject);
    }
}
