# Check if a binary tree is Binary Search Tree or Not
A Binary Tree is a Binary Search Tree <br/>
  if left subtree contains less or equal to the parent node's value and <br/>
  if the right subtree contains greater then parent node's value.
## Algorithm
```CSharp
bool IsBST(Node node)
{
  return IsBST(node, int.MinValue, int.MaxValue);
}

bool IsBST(Node node, int min, int max)
{
  return IsBST(node.Left, min, node.Data - 1) 
    && IsBST(node.Left, node.Data + 1, max);
}
```
## Complexity
Time Complexity: O(n)<br/>
Space Complexity: O(1), if recursive call stack is not considered, otherwise O(n)

## Blog
[www.raamte.net](http://ramate.net/check-if-a-binary-tree-is-binary-search-tree-or-not)
