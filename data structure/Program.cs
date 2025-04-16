

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



DynamicArray<string> dynamicarray = new DynamicArray<string>();
Console.WriteLine(dynamicarray.size);
Console.WriteLine(dynamicarray.capacity);
Console.WriteLine(dynamicarray.toString());

public class DynamicArray<T>
{
    public int size { get; private set; } = 0;
    public int capacity { get; private set; } = 10;
    T[] array;
    public DynamicArray()
    {
        this.array = new T[capacity];  
    }
    public DynamicArray(int capacity)
    {
        this.capacity = capacity;
        this.array = new T[capacity];
    }


    public void add(T value)
    {
        if (size < capacity) {
            grow();
        }
        array[size] = value;
        size++;
    }
    public void remove(T value)
    {
    }
    public void clear()
    {
    }

    public void insert(int index,T value)
    {

    }
    public int indexOf(T value)
    {
        return 1;
    }

    public void grow()
    {

    }
    public void shrink(int count)
    {

    }
    public bool isEmpty()
    {
        return size==0;
    }
    public string toString()
    {
        if (size == 0) return "[]";
        string ss = "";
        for (int i = 0; i <size; i++)
        {
            ss += array[i] + ", ";
        }
        return "[" + ss.Substring(0,ss.Length-2) + "]"; 
    }
}