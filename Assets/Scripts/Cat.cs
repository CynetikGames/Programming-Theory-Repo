using UnityEngine;

public class Cat : Animal
{
    [SerializeField]
    private int size = 1;
    private string catSays = " and a Cat says MEOW";

    public override string ShowInfo()
    {
        Debug.Log("Shows animal size Info: \n" + Name + "Size is: " + SetSize() + catSays);
        return "Shows animal size Info: \n" + Name + "Size is: " + SetSize() + catSays;
    }

    public override int SetSize()
    {
        return size;
    }
}


