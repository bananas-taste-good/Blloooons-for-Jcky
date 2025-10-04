using UnityEngine;
using System.Collections.Generic;
public class Tower_Behaviour : MonoBehaviour
{
    public float range;
    public int dmg;
    public int pierce;
    public GameObject target;
    public List<GameObject> possibleTargets = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        findNearestTarget();
        if (target != null)
        {
            transform.LookAt(target.transform.position);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
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
}