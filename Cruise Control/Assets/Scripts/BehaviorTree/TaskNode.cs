using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskNode : Node
{
    //Method signature for the task
    public delegate NodeStates TaskNodeDelegate();

    //Delegate that is called to evaluate this node
    private TaskNodeDelegate m_task;

    //Constructor
    public TaskNode(TaskNodeDelegate task)
    {
        m_task = task;
    }

    //Evaluates the node using the delegate that is passed in
    //and reports the resulting state as appropriate
    public override NodeStates Evaluate()
    {
        switch (m_task())
        {
            case NodeStates.SUCCESS:
                m_nodeState = NodeStates.SUCCESS;
                return m_nodeState;
            case NodeStates.FAILURE:
                m_nodeState = NodeStates.FAILURE;
                return m_nodeState;
            case NodeStates.RUNNING:
                m_nodeState = NodeStates.RUNNING;
                return m_nodeState;
            default:
                m_nodeState = NodeStates.FAILURE;
                return m_nodeState;
        }
    }
}
