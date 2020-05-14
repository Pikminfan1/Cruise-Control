using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTag : MonoBehaviour
{
    [SerializeField]
    private int Tag = 0;

    public int getTag()
    {
        return Tag;
    }

    public static bool operator ==(TileTag a, TileTag b)
    {
        if (a.Tag == b.Tag) return true;
        return false;
    }
    public static bool operator !=(TileTag a, TileTag b) { return !(a == b); }
}
