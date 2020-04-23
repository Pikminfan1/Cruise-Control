﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : TaskNode
{
    //child nodes for the selector
    protected List<TaskNode> m_nodes = new List<TaskNode>();

    //Passing in a list of child nodes
    public Selector(List<TaskNode> nodes)
    {
        m_nodes = nodes;
    }

    //If any child node is a success, then success is immediately reported.
    //Otherwise, if all the child nodes fail, failure is reported.
    public override NodeStates Evaluate()
    {
        foreach(TaskNode node in m_nodes)
        {
            switch (node.Evaluate())
            {
                case NodeStates.FAILURE:
                    continue;
                case NodeStates.SUCCESS:
                    m_nodeState = NodeStates.SUCCESS;
                    return m_nodeState;
                case NodeStates.RUNNING:
                    m_nodeState = NodeStates.RUNNING;
                    return m_nodeState;
                default:
                    continue;
            }
        }
        m_nodeState = NodeStates.FAILURE;
        return m_nodeState;
    }
}
