

Stack<string> stack = new Stack<string>();
Queue<string> queue = new Queue<string>();

stack.Push("A");
stack.Push("B");
stack.Push("C");
stack.Push("D");
stack.Pop();

//add element to queue 
queue.Enqueue("A");
queue.Enqueue("B");
queue.Enqueue("C");
queue.Enqueue("D");
queue.Dequeue();

LinkedList<string> linkedlist = new LinkedList<string>();


// like stack
//linkedlist.AddFirst("A");
//linkedlist.AddFirst("B");
//linkedlist.AddFirst("C");
//linkedlist.AddFirst("D");
//linkedlist.RemoveFirst();


// like queue
linkedlist.AddLast("A");
linkedlist.AddLast("B");
linkedlist.AddLast("C");
linkedlist.AddLast("D");
linkedlist.RemoveFirst();

//var node = linkedlist.Find("C");
//linkedlist.AddAfter(node,"aasd");



//Console.WriteLine(string.Join(" ,", stack));
//Console.WriteLine(string.Join(" ,", queue));
//Console.WriteLine(string.Join(" ,",linkedlist));  



public class Solution
{
    public bool IsPalindrome(int x)
    {
        string X = x.ToString();
        string Y = new string(X.Reverse().ToArray());
        return (X == Y);
    }
}