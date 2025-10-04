using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float timeToExpire = 2f;

    public float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToExpire)
        {
            Destroy(gameObject);
        }
    }
}
