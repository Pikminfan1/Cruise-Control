using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class TaskNode
{
    public enum NodeStates
    {
        SUCCESS,
        FAILURE,
        RUNNING
    }

    public delegate NodeStates NodeReturn();

    protected NodeStates m_nodeState;

    public NodeStates NodeState()
    {
        return m_nodeState;
    }

    public TaskNode() { }

    public abstract NodeStates Evaluate();
}
