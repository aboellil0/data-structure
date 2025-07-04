﻿

using System.Collections;
using System.Linq;

//Stack<string> stack = new Stack<string>();
//Queue<string> queue = new Queue<string>();

//stack.Push("A");
//stack.Push("B");
//stack.Push("C");
//stack.Push("D");
//stack.Pop();

////add element to queue 
//queue.Enqueue("A");
//queue.Enqueue("B");
//queue.Enqueue("C");
//queue.Enqueue("D");
//queue.Dequeue();

//LinkedList<string> linkedlist = new LinkedList<string>();


// like stack
//linkedlist.AddFirst("A");
//linkedlist.AddFirst("B");
//linkedlist.AddFirst("C");
//linkedlist.AddFirst("D");
//linkedlist.RemoveFirst();


// like queue
//linkedlist.AddLast("A");
//linkedlist.AddLast("B");
//linkedlist.AddLast("C");
//linkedlist.AddLast("D");
//linkedlist.RemoveFirst();

//var node = linkedlist.Find("C");
//linkedlist.AddAfter(node,"aasd");



//Console.WriteLine(string.Join(" ,", stack));
//Console.WriteLine(string.Join(" ,", queue));
//Console.WriteLine(string.Join(" ,",linkedlist));  



//DynamicArray<string> da = new DynamicArray<string>();

//da.add("A");
//da.add("B");
//da.add("C");
//da.add("D");
//da.add("E");
//da.add("F");

//da.remove("C");

//Console.WriteLine(da.size);
//Console.WriteLine(da.capacity);
//Console.WriteLine(da.toString());












//LinkedList<int> linkedlist = new LinkedList<int>();
//ArrayList arrayList = new ArrayList();


//DateTime startTime, endTime, elapsedTime;

//for (int i = 0; i<1000000;i++)
//{
//    linkedlist.AddFirst(i);
//    arrayList.Add(i);
//}

//*************linkedlist******************

//startTime = DateTime.Now;
//linkedlist.Find(0);
//linkedlist.Find(50000);
//linkedlist.Find(999999);
//linkedlist.AddBefore(linkedlist.Find(5000),525664645);
//linkedlist.Remove(999999);
//endTime = DateTime.Now;
//Console.WriteLine(endTime-startTime);

//*************arraylist*******************

//startTime = DateTime.Now;
//arrayList.IndexOf(0);
//arrayList.IndexOf(50000);
//arrayList.IndexOf(999999);
//arrayList.Insert(5000, 525664645);
//arrayList.Remove(999999);
//endTime = DateTime.Now;
//Console.WriteLine(endTime-startTime);

// binary search = Search algorithm that finds the position
//                  of a target value within a sorted array.
//                  Half of the array is eliminated during each "step"


//int[] array = new int[1000000];
//for (int i = 0; i < array.Length; i++)
//{ 
//    array[i] = i;
//}
//int target = 15;



//int index = array.BinarySearch(target);
//Console.WriteLine(index);








//interpolation search 
//using for unformaly distrputeed data
//o(log(log(n)))

//int[] array = {0,1,2,3,4,5,6,7,8,9};
//int[] array2 = {1,2,4,8,16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536 };
//int index = array2.InterpolationSearch(512);


//Console.WriteLine((index != -1) ? "found: "+index : "not found");






//bubble sort algorathem 
//o(n^2)

//int[] array = { 5, 4, 3, 2, 1 };
//array.BubbleSort(false);
//Console.WriteLine(string.Join(", ", array));




//SelectionSort
//o(n^2)

//int[] array = { 5, 4, 3, 2, 1 };
//array.SelectionSort(false);
//Console.WriteLine(string.Join(", ", array));







//insertion sorting 
//o(n^2)

//int[] array = { 5, 0, 6, 8,2, 9, 1, 3 };
//array.InsertionSorting();
//Console.WriteLine(string.Join(", ",array));



//extentionMethods.walk(5);
//Console.WriteLine(extentionMethods.Factorial(2));



// marage sort algorathem 
// o(n log(n))
int[] array = new int[] { 5, 4, 3, 2, 1 };
array.merageSort();
Console.WriteLine(string.Join(", ", array));


public static class extentionMethods
{

    public static void merageSort(this int[] array)
    {
        int length = array.Length;
        if (length <= 1) return;

        int middle = length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }
        for (int i = middle; i < length; i++)
        {
            rightArray[i - middle] = array[i];
        }

        merageSort(leftArray);
        merageSort(rightArray);
        merge(leftArray, rightArray, array);
    }
    private static void merge(int[] leftArray, int[] rightArray, int[] array)
    {
        int leftSize = leftArray.Length;
        int rightSize = rightArray.Length;

        int i = 0, l = 0, r = 0;

        while (l < leftSize && r < rightSize)
        {
            if (leftArray[l] < rightArray[r])
            {
                array[i] = leftArray[l];
                l++;
            }
            else
            {
                array[i] = rightArray[r];
                r++;
            }
            i++;
        }

        while (l < leftSize)
        {
            array[i] = leftArray[l];
            l++;
            i++;
        }

        while (r < rightSize)
        {
            array[i] = rightArray[r];
            r++;
            i++;
        }
    }

    public static int Factorial(int num)
    {
        if (num == 0) return 1;
        return num * Factorial(num - 1);
    }
    public static void walk(int num)
    {
        if (num == 0) return;
        Console.WriteLine(num);
        walk(num - 1);
    }
    public static void InsertionSorting(this int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;
            for (; j>=0 && array[j] > temp;)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j+1] = temp;
        }
    }

    public static void SelectionSort(this int[] array,bool ASC)
    {
        for (int i = 0; i < array.Length -1; i++)
        {
            int minIndex = i;
            for (global::System.Int32 j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex] && ASC)
                {
                    minIndex = j;
                }
                else if (array[j] > array[minIndex] && !ASC)
                {
                    minIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
    public static void BubbleSort(this int[] array,bool ASC)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (global::System.Int32 j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1] && ASC)
                {
                    int temp = array[j];
                    array[j] =array[j + 1];
                    array[j + 1] = temp;
                }
                else if (array[j] < array[j + 1] && !ASC)
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
        

    public static int InterpolationSearch(this int[] array, int value)
    {
        int high = array.Length - 1;
        int low = 0;
        while(value >= array[low] && value <= array[high] && low <= high)
        {
            if (low == high) return low;
            int mid = low + ((value - array[low]) * (high - low)) / (array[high] - array[low]);
            if (array[mid] == value) return mid;
            else if (array[mid] < value) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    public static int BinarySearch(this int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int middleIndex = (low + high) / 2;
            int value = array[middleIndex];
            Console.WriteLine("Middle value: " + middleIndex);

            if (value < target) low = middleIndex + 1;
            else if (value > target) high = middleIndex - 1;
            else return middleIndex;

        }
        return -1;
    }
}








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
        for (int i = 0; i < size; i++)
        {
            if (array[i].Equals(value))
            {
                for (int j = i;j < size-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[size-1] = default;
                size--;
                if (size < (int)(capacity/3))
                {
                    shrink();
                }
                break;
            }
        }
    }
    public void clear()
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = default;   
        }
        size = 0;
    }
    public void insert(int index,T value)
    {
        if (size + 1 < capacity)
        {
            grow();
        }
        for (int i = size; i > index; i--)
        {
            array[i] = array[i - 1];
        }
        size++;
    }
    public int indexOf(T value)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i].Equals(value)) return i;
        }
        return -1;
    }

    public void grow()
    {
        int newCapacity = (int)capacity*2;
        T[] newArray = new T[newCapacity];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }
        capacity = newCapacity;
        array = newArray;
    }
    public void shrink()
    {
        int NewCapacity = (int)capacity / 2;
        T[] newArray = new T[NewCapacity];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }
        capacity = NewCapacity;
        array = newArray;
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