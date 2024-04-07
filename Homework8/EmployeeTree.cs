namespace Homework8
{
    public class EmployeeTree
    {
        private EmployeeTreeNode? _root;

        public void Traversal()
        {
            Traversal(_root);
        }

        public string? FindEmployeeNameBySalary(int salary) 
        {
            var treeNode = FindTreeNodeBySalary(_root, salary);
            return treeNode?.Name;
        }

        public void Add(string name, int salary)
        {
            var employeeTreeNode = new EmployeeTreeNode(name, salary);
            if (_root == null)
            {
                _root = employeeTreeNode;
            }
            else
            {
                AddTreeNode(_root, employeeTreeNode);
            }
        }

        public void Clear()
        {
            _root = null;
        }

        private void Traversal(EmployeeTreeNode? root)
        {
            if (root?.Left != null) Traversal(root.Left);
            Console.WriteLine(root);
            if (root?.Right != null) Traversal(root.Right);
        }

        private EmployeeTreeNode? FindTreeNodeBySalary(EmployeeTreeNode? root, int salary)
        {
            if (salary < root?.Salary)
            {
                return root.Left != null ? FindTreeNodeBySalary(root.Left, salary) : null;
            }
            else if (salary > root?.Salary)
            {
                return root.Right != null ? FindTreeNodeBySalary(root.Right, salary) : null;
            }
            return root;
        }

        private void AddTreeNode(EmployeeTreeNode root, EmployeeTreeNode node)
        {
            if (node.Salary < root.Salary)
            {
                if (root.Left == null)
                {
                    root.Left = node;
                }
                else
                {
                    AddTreeNode(root.Left, node);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = node;
                }
                else
                {
                    AddTreeNode(root.Right, node);
                }
            }
        }

        private class EmployeeTreeNode
        {
            public string Name { get;}
            public int Salary { get;}
            public EmployeeTreeNode? Left { get; internal set; }
            public EmployeeTreeNode? Right { get; internal set; }

            public EmployeeTreeNode(string name, int salary)
            {
                Name = name;
                Salary = salary;
            }

            public override string ToString()
            {
                return $"{Name} - {Salary}";
            }
        }
    }
}
