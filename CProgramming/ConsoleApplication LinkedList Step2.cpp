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
//6) while n != ∅ and n.Value != value
//7) n ← n.Next
//8) end while
//9) if n = ∅
//10) return false
//11) end if
//12) return true
//13) end Contains
bool Contains(Node* head, int value)
{
    bool bfound = false;
    Node* n;
    n = head;
    while (n != 0 ) {
        if (n->Value == value) {
            bfound = true;
            break;
        }
        n = n->Next;
    }
    return bfound;
}

//1) algorithm Remove(head, value)
//2) Pre: head is the head node in the list
//3) value is the value to remove from the list
//4) Post: value is removed from the list, true; otherwise false
//5) if head = ∅
//6) // case 1
//7) return false
//8) end if
//9) n ← head
//10) if n.Value = value
//11) if head = tail
//12) // case 2
//13) head ← ∅
//14) tail ← ∅
//15) else
//16) // case 3
//17) head ← head.Next
//18) end if
//19) return true
//20) end if
//21) while n.Next 6 = ∅ and n.Next.Value 6 = value
//22) n ← n.Next
//23) end while
//24) if n.Next 6 = ∅
//25) if n.Next = tail
//26) // case 4
//27) tail ← n
//28) end if
//29) // this is only case 5 if the conditional on line 25 was false
//30) n.Next ← n.Next.Next
//31) return true
//32) end if
//33) // case 6
//34) return false
//35) end Remove

bool Remove(Node* & head_, int value)
{
    Node* curr = head_;
    Node* prev = nullptr;
    //Node* next = nullptr;
    bool bfound = false;
    if (curr == nullptr)
        return false;
    while (curr != nullptr)
    {
        if (curr->Value == value)
        {
            bfound = true;
            if (prev != nullptr)
            {
                prev->Next = curr->Next;
                if (curr->Next == nullptr) // tail check
                    tail = prev;
            }
            else // head check
                head_ = curr->Next;
            delete curr;
            break;
        }
        prev = curr;
        curr = curr->Next;
    }
    return bfound;
}

void main()
{
    Add(1);
    Add(45);
    Add(60);
    Add(12);
    printf("%s\r\n", Remove(head,12) ? "true" : "false");
    Add(99);
    PrintAll();
    ReleaseAll();
}