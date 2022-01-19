using Kiwiplan.Challenge.CA.Core.Domain;
using Kiwiplan.Challenge.CA.Core.Domain.Individual;
using System.Collections.Generic;
using System.Linq;

namespace Kiwiplan.Challenge.CA.Core.Utilities.HierarchicalTree
{
    public class TreeNode : HierarchicalTreeBase
    {
        public TreeNode() : base() { }

        public TreeNode(IList<TreeNode> childs) : base(childs) { }

        public IndividualBase Individual { get; set; }=new Employee();

        // manipulation actions overrides
        public override void AddChild(TreeNode tnode) => this?.Childs?.ToList()?.Add(tnode);
        public override void RemoveChild(TreeNode tnode) => this?.Childs?.ToList()?.Remove(tnode);
 
        /// <summary>
        ///  usage of recursion to handle solution of hierarrchical tree issues (multi nested trees )
        /// </summary>
        public override string DisplayCurrentNodeTree()
        {
            var result = this?.Individual?.Name ?? string.Empty;

            var currentchildren = this?.Childs.ToList(); 

            foreach (var outout in currentchildren)
                result += outout.DisplayCurrentNodeTree();

            return result;
        }
    } 
}
