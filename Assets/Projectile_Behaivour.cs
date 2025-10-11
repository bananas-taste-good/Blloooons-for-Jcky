using UnityEngine;

public class Projectile_Beha : MonoBehaviour
{
    public float timer;

    public float lifeTime;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifeTime)
        {
            Destroy(gameObject);
        }
    }

    
}
