using System;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private string name;
    private int size;

    public string Name
    {
        get { return name; }
        set
        {
            if (value == "cat" || value == "dog")
            {
                name = value;
            }
            else
            {
                Debug.Log("Please enter \"cat\" or \"dog\" for animal name");
            }
        }
    }

    public virtual string ShowInfo()
    {
        Debug.Log("Shows animal size Info: \n" + Name + " size is: " + SetSize());
        return "";
    }

    public virtual int SetSize()
    {
        return size;
    }
}
