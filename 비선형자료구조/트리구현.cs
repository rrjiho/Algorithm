class TreeNode<T>
{
    public T Data { get; set; }
    public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
}

public class Program
{
    static TreeNode<string> MakeTree()
    {
        TreeNode<string> root = new TreeNode<string>() { Data = "1팀" };
        {
            {
                TreeNode<string> node = new TreeNode<string>() { Data = "공격팀" };
                node.Children.Add(new TreeNode<string>() { Data = "ST" });
                node.Children.Add(new TreeNode<string>() { Data = "LW" });
                node.Children.Add(new TreeNode<string>() { Data = "RW" });
                root.Children.Add(node);
            }

            {
                TreeNode<string> node = new TreeNode<string>() { Data = "중앙팀" };
                node.Children.Add(new TreeNode<string>() { Data = "CM" });
                node.Children.Add(new TreeNode<string>() { Data = "LM" });
                node.Children.Add(new TreeNode<string>() { Data = "RM" });
                root.Children.Add(node);
            }

            {
                TreeNode<string> node = new TreeNode<string>() { Data = "수비팀" };
                node.Children.Add(new TreeNode<string>() { Data = "CB" });
                node.Children.Add(new TreeNode<string>() { Data = "LB" });
                node.Children.Add(new TreeNode<string>() { Data = "RB" });
                root.Children.Add(node);
            }
        }
        return root;
    }

    // 재귀적 성질 이용
    static void PrintTree(TreeNode<string> root)
    {
        Console.WriteLine(root.Data);

        foreach(TreeNode<string> child in root.Children)
            PrintTree(child);
    }

    static int GetHeight(TreeNode<string> root)
    {
        int height = 0;

        foreach (TreeNode<string> child in root.Children)
        {
            int newHeight = GetHeight(child) + 1;
            if(height < newHeight)
                height = newHeight;
            // height = Math.Max(height, newHeight);
        }

        return height;
    }

    static void Main(string[] args)
    {
        TreeNode<string> root = MakeTree();

        PrintTree(root);

        GetHeight(root);
    }
}
