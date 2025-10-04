using UnityEngine;
using System.Collections.Generic;
public class Tower_Behaviour : MonoBehaviour
{
    public float range;
    public int dmg;
    public int pierce;
    public GameObject target;
    public List<GameObject> possibleTargets = new List<GameObject>();
    public float fireRate;
    public float fireCountdown = 0f;

    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fireCountdown += Time.deltaTime;


        findNearestTarget();
        if (target != null)
        {
            transform.LookAt(target.transform.position);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            {
                fireCountdown = 0f;
                Hearts h = target.GetComponent<Hearts>();
                h.takeDmg(dmg);
                fireProjectile();
                if (h.health <= 0)
                {
                    possibleTargets.Remove(target);
                    h.die();
                    target = null;

                }
            }



        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bloon")
        {
            possibleTargets.Add(other.gameObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "bloon")
        {
            possibleTargets.Remove(other.gameObject);
        }

    }

    public void findNearestTarget()
    {
        GameObject closest = null;
        foreach (GameObject trg in possibleTargets)
        {
            closest = possibleTargets[0];

            if (Vector3.Distance(transform.position, closest.transform.position) > Vector3.Distance(transform.position, trg.transform.position))
            {
                closest = trg;
            }
        }
        target = closest;
    }
    public void fireProjectile()
    {
        GameObject newProj = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Rigidbody rb = newProj.GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * 10;
    }
}