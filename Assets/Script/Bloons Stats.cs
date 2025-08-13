using UnityEngine;

public class BloonsStats : MonoBehaviour
{
    public float health;
    public float damage;
    public float speed;
    public float maxHealth;
    public float hpScale;
    public float cash;

    public bool regen;
    public bool camo;
    public bool ceramic;
    public bool lead;
    public bool black;
    public bool white;
    public bool purple;
    public bool moab;

    public BloonsStats lowerTier;
    public BloonsStats upperTier;

    public void takeDmg(float dmg)
    (
        health -= dmg;
    )

    public void regenerate()
    (
        if (regen)
        (
            health = upperTier.health;
            damage = upperTier.damage;
            speed = upperTier.speed;
            maxHealth = upperTier.maxHealth;
            hpScale = upperTier.hpScale;
            cash = upperTier.cash;
            lead = upperTier.lead;
            black = upperTier.black;
            white = upperTier.white;
            purple = upperTier.purple;
            ceramic = upperTier.ceramic;
        )
    )

    public void downgrade()
    (
        health = lowerTierTier.health;
        damage = lowerTier.damage;
        speed = lowerTier.speed;
        maxHealth = lowerTier.maxHealth;
        hpScale = lowerTier.hpScale;
        cash = lowerTier.cash;
        lead = lowerTier.lead;
        black = lowerTier.black;
        white = lowerTier.white;
        purple = lowerTier.purple;
        ceramic = lowerTier.ceramic;
    )
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
