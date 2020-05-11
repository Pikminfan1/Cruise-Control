using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Node
{   
    //Delegate that returns the state of the node
    public delegate NodeStates NodeReturn();

    //current state of the node
    protected NodeStates m_nodeState;

    public NodeStates nodeState()
    {
        return m_nodeState;
    }

    //constructor for node
    public Node() { }

    //Implementing classes use this method to evalute the desired set of conditions
    public abstract NodeStates Evaluate();
}
