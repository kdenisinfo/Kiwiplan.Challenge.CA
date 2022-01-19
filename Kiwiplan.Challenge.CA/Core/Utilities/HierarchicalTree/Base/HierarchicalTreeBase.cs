using System.Collections.Generic;
using System.Linq;

namespace Kiwiplan.Challenge.CA.Core.Utilities.HierarchicalTree
{
    public abstract class HierarchicalTreeBase  : IRootable, IManageable
    {
        public IList<TreeNode> Childs { get; set; }=new List<TreeNode>();

        public bool IsRoot { get; set; }
        public bool IsManager { get=>this?.Childs?.Count() > 0; }
        public bool HasChilds { get=>this?.Childs?.Count() > 0;  }

        protected HierarchicalTreeBase() { }
        protected HierarchicalTreeBase(IList<TreeNode> childs)=>Childs=childs ?? new List<TreeNode>()/*throw new ArgumentNullException(nameof(childs))*/;

        public abstract void AddChild(TreeNode tnode) ;
        public abstract void RemoveChild(TreeNode tnode);
        public abstract string DisplayCurrentNodeTree();
    }
}
