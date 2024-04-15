namespace binary_example;

public class TreeNode
{
    private int date;

    public int Data
    {
        get { return date; }
    }

    private TreeNode rightNode;

    public TreeNode RightNode
    {
        get { return rightNode;}
        set { rightNode = value; }
    }
    
    private TreeNode leftNode;

    public TreeNode LeftNode
    {
        get { return leftNode;}
        set { leftNode = value; }
    }

    public TreeNode(int value)
    {
        date = value;
    }
}

public class BinaryTree
{
    
}