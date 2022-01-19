using Kiwiplan.Challenge.CA.Core.Domain;
using Kiwiplan.Challenge.CA.Core.Utilities.HierarchicalTree;

namespace Kiwiplan.Challenge.CA
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var rootaministration = new Manager() { Name="Tom", Title="Root Admin", Guid=0, } ;

            var mickey = new Employee() { Name = "Mickey",  ManagerId=1, Title="Stuff"  };
            var jerry  = new Employee() { Name = "Jerry", ManagerId = 1, Title = "Stuff" };
            var sarah  = new Employee() { Name = "Sarah", ManagerId = 1, Title = "Stuff" };
            var john   = new Employee() { Name = "John", ManagerId = 2, Title = "Stuff" };

            var rootnode = new TreeNode() { Individual= rootaministration, IsRoot = true };

            rootnode.Childs/*.ToList<TreeNode>()*/.Add(new TreeNode(){ Individual = mickey });
            rootnode.Childs.Add(new TreeNode() { Individual = jerry });
            rootnode.Childs.Add(new TreeNode() { Individual = sarah });
            rootnode.Childs.Add(new TreeNode() { Individual = john });


            string output = rootnode.DisplayCurrentNodeTree();
        }
    }
}
