using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : TaskNode
{
    //child nodes for the sequence
    protected List<TaskNode> m_nodes = new List<TaskNode>();

    //Passing in a list of child nodes
    public Sequence(List<TaskNode> nodes)
    {
        m_nodes = nodes;
    }

    //If any child node returns failure, the whole sequence fails.
    //When a child node is successful, a success is return.
    public override NodeStates Evaluate()
    {
        bool anyChildRunning = false;

        foreach (TaskNode node in m_nodes)
        {
            switch (node.Evaluate())
            {
                case NodeStates.FAILURE:
                    m_nodeState = NodeStates.FAILURE;
                    return m_nodeState;
                case NodeStates.SUCCESS:
                    continue;
                case NodeStates.RUNNING:
                    anyChildRunning = true;
                    continue;
                default:
                    m_nodeState = NodeStates.SUCCESS;
                    return m_nodeState;
            }
        }
        m_nodeState = anyChildRunning ? NodeStates.RUNNING : NodeStates.SUCCESS;
        return m_nodeState;
    }
}
