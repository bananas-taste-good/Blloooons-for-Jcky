using UnityEngine;

public class FollowNode : MonoBehaviour
{
    public Transform[] nodes;
    public int currentNode;
    public int maxNodes;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxNodes = nodes.Length;
        GameObject mainFolder = GameObject.Find("Path Finding");
        int counter = 0;
        foreach(Transform child in mainFolder.transform)
        {
            nodes[counter] = child;
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(currentNode < maxNodes - 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, nodes[currentNode].position, speed * Time.deltaTime);
            if(Vector3.Distance(transform.position, nodes[currentNode].position) <= .1f)
            {
                currentNode += 1;
            }
        }
    }
}