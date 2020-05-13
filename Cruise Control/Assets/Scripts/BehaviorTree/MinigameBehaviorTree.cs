using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameBehaviorTree : MonoBehaviour
{
    private GameObject cone;
    private GameObject phone;
    private bool coneIsActive;
    private bool phoneIsActive;

    //All the nodes in the tree
    public TaskNode coneActiveNode;
    public TaskNode phoneActiveNode;
    public Sequence activateObjectsSequence;
    public Selector rootNode;

    public delegate void TreeExecuted();
    public event TreeExecuted onTreeExecuted;

    // Start is called before the first frame update
    void Start()
    {
        cone = GameObject.Find("trafficcone");
        cone.SetActive(false);
        coneIsActive = false;

        phone = GameObject.Find("cellphone");
        phone.SetActive(false);
        phoneIsActive = false;

        coneActiveNode = new TaskNode(ActivateCone);

        phoneActiveNode = new TaskNode(ActivatePhone);

        activateObjectsSequence = new Sequence(new List<Node>
        {
            coneActiveNode,
            phoneActiveNode,
        });

        rootNode = new Selector(new List<Node>
        {
            activateObjectsSequence,
        });
    }

    private void Update()
    {
        //Executes the behavior tree every update
        this.Evaluate();
    }

    public void Evaluate()
    {
        //start from the root node
        rootNode.Evaluate();
        StartCoroutine(Execute());
    }

    private IEnumerator Execute()
    {
        //Debug.Log("Waiting...");
        yield return new WaitForSeconds(2f);


        //if (coneActiveNode.nodeState() == NodeStates.SUCCESS)
        //{
        //    Debug.Log("Activate Cone");
        //    cone.SetActive(true);
        //    coneIsActive = true;
        //} else if(phoneActiveNode.nodeState() == NodeStates.SUCCESS) {
        //    Debug.Log("Activate Phone");
        //    phone.SetActive(true);
        //    phoneIsActive = true;
        //}

        //Here is where the action happens if a node is a success
        if(activateObjectsSequence.nodeState() == NodeStates.SUCCESS)
        {
            Debug.Log("Activate Objects");
            cone.SetActive(true);
            coneIsActive = true;
            phone.SetActive(true);
            phoneIsActive = true;
        }

        if(onTreeExecuted != null)
        {
            onTreeExecuted();
        }
    }


    private NodeStates ActivateCone()
    {
        if (!coneIsActive)
        {
            return NodeStates.SUCCESS;
        }
        else
        {
            return NodeStates.FAILURE;
        }
    }

    private NodeStates ActivatePhone()
    {
        if (!phoneIsActive)
        {
            return NodeStates.SUCCESS;
        }
        else
        {
            return NodeStates.FAILURE;
        }
    }
}
