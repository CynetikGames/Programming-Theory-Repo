using UnityEngine;

public class Dog : Animal
{
    [SerializeField]
    private int size = 2;
    private string dogSays = " and a Dog says WORF";

    public override string ShowInfo()
    {
        Debug.Log("Shows animal size Info: \n" + Name + "Size is: " + SetSize() + dogSays);
        return "Shows animal size Info: \n" + Name + "Size is: " + SetSize() + dogSays;
    }

    public override int SetSize()
    {
        return size;
    }
}


