#include <stdio.h>
#define TEST
#define PI      3.141592

struct Node
{
    int     Value;
    Node*   Next;
};

Node* head = nullptr;
Node* tail = nullptr;

Node* node(int value)
{
    Node* n = new Node();
    n->Value = value;
    n->Next = nullptr;
    return n;
}

//1) algorithm Add(value)
void Add(int value)
{
    //2) Pre: value is the value to add to the list
    //3) Post: value has been placed at the tail of the list
    //4) n ← node(value)
    Node* n = node(value);
    if (head == 0) {
        //5) if head = ∅
        //6) head ← n
        //7) tail ← n
        //8) else
        head = n;
        tail = n;
    }
    else
    {
        //9) tail.Next ← n
        //10) tail ← n
        //11) end if
        tail->Next = n;
        tail = n;
    }
    //12) end Add
}

void ReleaseAll()
{
#if defined(TEST) && defined(_DEBUG)
    int count = 0;
#endif
    Node* t = head;
    while (t != 0) {
        Node* t2 = t->Next;
        delete t;
        t = t2;
#if defined(TEST) && defined(_DEBUG)
        count += 1;
#endif
    }
#if defined(TEST) && defined(_DEBUG)
    printf("count = %i\r\n", count);
#endif
}

void PrintAll()
{
    Node* t = head;
    while (t != 0) {
        printf("%i,", t->Value);
        t = t->Next;
    }
}

//1) algorithm Contains(head, value)
//2) Pre: head is the head node in the list
//3) value is the value to search for
//4) Post: the item is either in the linked list, true; otherwise false
//5) n ← head
//6) while n 6 = ∅ and n.Value 6 = value
//7) n ← n.Next
//8) end while
//9) if n = ∅
//10) return false
//11) end if
//12) return true
//13) end Contains

void main()
{
    Add(1);
    Add(45);
    Add(60);
    Add(12);
    PrintAll();
    ReleaseAll();
}