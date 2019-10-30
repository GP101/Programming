#include <stdio.h>

struct Node
{
    Node* Left;
    Node* Right;
    int Value;
};

Node* root = nullptr;

Node* node(int value)
{
    return new Node{nullptr,nullptr,value};
}

void InsertNode(Node* root, int value);
void Insert(int value)
{
    if (root == nullptr)
        root = node(value);
    else
        InsertNode(root, value);
}

void InsertNode(Node* current, int value)
{
    if (value < current->Value) {
        if (current->Left == nullptr)
            current->Left = node(value);
        else
            InsertNode(current->Left, value);
    } 
    else {
        if (current->Right == nullptr)
            current->Right = node(value);
        else
            InsertNode(current->Right, value);
    }
}

bool Contains(Node* root, int value)
{
    if (root == nullptr)
        return false;
    if (root->Value == value)
        return true;
    else if (value < root->Value)
        return Contains(root->Left, value);
    else
        return Contains(root->Right, value);
}

void Print(Node* current)
{
    if (current == nullptr)
        return;
    printf("%i\r\n", current->Value);
    Print(current->Left);
    Print(current->Right);
}

Node* FindParent(int value, Node* root)
{
    if (root == nullptr)
        return nullptr;
    if (value == root->Value)
        return nullptr;
    if (value < root->Value) {
        if (root->Left == nullptr)
            return nullptr;
        else if (root->Left->Value == value)
            return root;
        else
            return FindParent(value, root->Left);
    }
    else {
        if (root->Right == nullptr)
            return nullptr;
        else if (root->Right->Value == value)
            return root;
        else
            return FindParent(value, root->Right);
    }
}

Node* FindParent(int value, Node* current, Node* root)
{
    if (current == nullptr)
        return nullptr;
    if (value == current->Value)
        return root;
    Node* leftsubtree = nullptr;
    Node* rightsubtree = nullptr;
    leftsubtree = FindParent(value, current->Left, current);
    if (leftsubtree != nullptr)
        return leftsubtree;
    rightsubtree = FindParent(value, current->Right, current);
    if (rightsubtree != nullptr)
        return rightsubtree;
}

Node* FindNode(Node* root, int value)
{
    if (root == nullptr)
        return nullptr;
    if (value == root->Value)
        return root;
    else if (value < root->Value)
        return FindNode(root->Left, value);
    else
        return FindNode(root->Right, value);
}

bool Remove(int value, Node* root)
{
    Node* nodeToRemove = FindNode(root, value);
    if (nodeToRemove == nullptr)
        return false;
    Node* parent = FindParent(value, nodeToRemove);
    if (nodeToRemove->Left == 0 && nodeToRemove->Right == 0)
    {
    }
    else if (nodeToRemove->Left == 0 && nodeToRemove->Right != 0)
    {
    }
    else if (nodeToRemove->Left != 0 && nodeToRemove->Right == 0)
    {
    }
    else
    {
        Node* largestValue = nodeToRemove->Left;
        while (largestValue->Right != 0)
            largestValue = largestValue->Right;
        Node* p = FindParent(largestValue->Value, root);
        p->Right = nullptr;
        nodeToRemove->Value = largestValue->Value;
    }
    return false;
}

void main()
{
    int a[]{ 23, 14, 31, 7, 17, 9 };
    for (const int i : a) {
        Insert(i);
    }
    Print(root);
    Remove(14, root);
    Print(root); // 23, 9, 7, 17, 31
}