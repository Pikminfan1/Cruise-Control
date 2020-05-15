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
    //public TaskNode coneActiveNode;
    //public TaskNode phoneActiveNode;
    //public Sequence activateObjectsSequence;
    public TaskNode childGameNode;
    public TaskNode trashGameNode;
    public TaskNode foodGameNode;
    public TaskNode drinkGameNode;
    public TaskNode coneGameNode;
    public Sequence childAndOtherSequence;
    public Sequence childAndTwoOthersSequence;
    public Selector rootNode;

    //Minigames
    ChildCryingMinigame cmg;

    public delegate void TreeExecuted();
    public event TreeExecuted onTreeExecuted;

    // Start is called before the first frame update
    void Start()
    {
        //cone = GameObject.Find("trafficcone");
        //cone.SetActive(false);
        //coneIsActive = false;

        //phone = GameObject.Find("cellphone");
        //phone.SetActive(false);
        //phoneIsActive = false;

        //coneActiveNode = new TaskNode(ActivateCone);

        //phoneActiveNode = new TaskNode(ActivatePhone);

        //activateObjectsSequence = new Sequence(new List<Node>
        //{
        //    coneActiveNode,
        //    phoneActiveNode,
        //});

        //rootNode = new Selector(new List<Node>
        //{
        //    activateObjectsSequence,
        //});

        //Initialize minigame
        cmg = new ChildCryingMinigame();

    }

    public void buildTree()
    {
        //initiliaze nodes
        childGameNode = new TaskNode(CheckChildGame);
        //trashGameNode = new TaskNode(CheckTrashGame);
        //foodGameNode = new TaskNode(CheckFoodGame);
        //drinkGameNode = new TaskNode(CheckDrinkGame);
        //coneGameNode = new TaskNode(CheckConeGame);

        TaskNode [] part_mg_list = new TaskNode[] { trashGameNode, foodGameNode, drinkGameNode, coneGameNode };
        //for choosing a random minigame to partner with sequence games
        int mg_index = Random.Range(0, part_mg_list.Length-1);

        //attaching nodes to tree
 
        childAndOtherSequence = new Sequence(new List<Node> {
            childGameNode,
            part_mg_list[mg_index],
        });

        childAndTwoOthersSequence = new Sequence(new List<Node> {
            childGameNode,
            trashGameNode,
            coneGameNode,
        });

        rootNode = new Selector(new List<Node> {
            childGameNode,
            trashGameNode,
            foodGameNode,
            drinkGameNode,
            coneGameNode,
            childAndOtherSequence,
            childAndTwoOthersSequence,
        });
    }

    private void Update()
    {
        ////Executes the behavior tree every update
        //this.Evaluate();
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
        yield return new WaitForSeconds(5f);


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
        //if(activateObjectsSequence.nodeState() == NodeStates.SUCCESS)
        //{
        //    Debug.Log("Activate Objects");
        //    cone.SetActive(true);
        //    coneIsActive = true;
        //    phone.SetActive(true);
        //    phoneIsActive = true;
        //}

        if(childGameNode.nodeState() == NodeStates.SUCCESS)
        {
            cmg.MiniGameStart();
        }

        if(onTreeExecuted != null)
        {
            onTreeExecuted();
        }
    }

    private NodeStates CheckChildGame()
    {
        if (!cmg.IsPlaying)
        {
            return NodeStates.SUCCESS;
        }
        else
        {
            return NodeStates.FAILURE;
        }
    }

    //private NodeStates CheckTrashGame()
    //{
    //    if (!TrashMinigame.IsPlaying)
    //    {
    //        return NodeStates.SUCCESS;
    //    }
    //    else
    //    {
    //        return NodeStates.FAILURE;
    //    }
    //}

    //private NodeStates CheckFoodGame()
    //{
    //    if (!FoodMinigame.IsPlaying)
    //    {
    //        return NodeStates.SUCCESS;
    //    }
    //    else
    //    {
    //        return NodeStates.FAILURE;
    //    }
    //}

    //private NodeStates CheckDrinkGame()
    //{
    //    if (!DrinkMinigame.IsPlaying)
    //    {
    //        return NodeStates.SUCCESS;
    //    }
    //    else
    //    {
    //        return NodeStates.FAILURE;
    //    }
    //}

    //private NodeStates CheckConeGame()
    //{
    //    if (!ConeMinigame.IsPlaying)
    //    {
    //        return NodeStates.SUCCESS;
    //    }
    //    else
    //    {
    //        return NodeStates.FAILURE;
    //    }
    //}

    //private NodeStates ActivateCone()
    //{
    //    if (!coneIsActive)
    //    {
    //        return NodeStates.SUCCESS;
    //    }
    //    else
    //    {
    //        return NodeStates.FAILURE;
    //    }
    //}

    //private NodeStates ActivatePhone()
    //{
    //    if (!phoneIsActive)
    //    {
    //        return NodeStates.SUCCESS;
    //    }
    //    else
    //    {
    //        return NodeStates.FAILURE;
    //    }
    //}
}
