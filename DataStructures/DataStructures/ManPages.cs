using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ManPages
    {

        public static void accessPages()
        {
            
            string queueMan =
                "This class implements a queue as a circular array. Objects stored in a Queue are inserted at one end and removed from the other." +
"Queues and stacks are useful when you need temporary storage for information; " +
            "that is, when you might want to discard an element after retrieving its value. " +
            "Use Queue if you need to access the information in the same order that it is stored in the collection. " +
            "Use Stack if you need to access the information in reverse order. Use ConcurrentQueue<T> or ConcurrentStack<T> " +
            "if you need to access the collection from multiple threads concurrently." +
"Three main operations can be performed on a Queue and its elements:" +
"Enqueue adds an element to the end of the Queue." +
"Dequeue removes the oldest element from the start of the Queue." +
"Peek returns the oldest element that is at the start of the Queue but does not remove it from the Queue." +
"The capacity of a Queue is the number of elements the Queue can hold. As " +
            "elements are added to a Queue, the capacity is automatically " +
             "increased as required through reallocation. The capacity can be decreased by calling TrimToSize." +
"The growth factor is the number by which the current capacity is multiplied" +
           " when a greater capacity is required. The growth factor is d" +
            "etermined when the Queue is constructed. The default growth factor is 2.0. " +
            "The capacity of the Queue will always increase by at least a minimum of four, " +
            "regardless of the growth factor. For example, a Queue with a growth factor of 1.0 will" +
            "always increase in capacity by four when a greater capacity is required." +
"Queue accepts null as a valid value and allows duplicate elements.";

            string stackMan =
                "For the generic version of this collection, see System.Collections.Generic.Stack<T>." +
"The capacity of a Stack is the number of elements the Stack can hold. As elements are added to a Stack, " +
 "the capacity is automatically increased as required through reallocation." +
"If Count is less than the capacity of the stack, Push is an O(1) operation. If the capacity needs to be" +
           "increased to accommodate the new element, Push becomes an O(n) operation, where n is Count. " +
 "Pop is an O(1) operation." +
"Stack accepts null as a valid value and allows duplicate elements.";

            string dictionaryMan =
       "The Dictionary<TKey, TValue> generic class provides a mapping from a set of" +
    "keys to a set of values. Each addition to the dictionary consists of a value " +
     "and its associated key. Retrieving a value by using its key is very fast, " +
  "close to O(1), because the Dictionary<TKey, TValue> class is implemented as a hash table." +
"System_CAPS_noteNote" +
"The speed of retrieval depends on the quality of the hashing algorithm of the type specified for TKey." +
"As long as an object is used as a key in the Dictionary<TKey, TValue>, it must not change in " +
          "any way that affects its hash value. Every key in a Dictionary<TKey, TValue> must be " +
          "unique according to the dictionary's equality comparer. A key cannot be null, but " +
        "a value can be, if the value type TValue is a reference type." +
"Dictionary<TKey, TValue> requires an equality implementation to determine whether keys are equal. " +
   " You can specify an implementation of the IEqualityComparer<T> generic interface by using a " +
      "  constructor that accepts a comparer parameter; if you do not specify an implementation, " +
          "the default generic equality comparer EqualityComparer<T>.Default is used. If type " +
           " TKey implements the System.IEquatable<T> generic interface, the default equality comparer uses that implementation." +
"System_CAPS_noteNote" +
"For example, you can use the case-insensitive string comparers provided by the StringComparer" +
          "  class to create dictionaries with case-insensitive string keys." +
"The capacity of a Dictionary<TKey, TValue> is the number of elements the Dictionary<TKey," +
           " TValue> can hold. As elements are added to a Dictionary<TKey, TValue>, the capacity" +
          "  is automatically increased as required by reallocating the internal array." +
"For very large Dictionary<TKey, TValue> objects, you can increase the maximum capacity to 2" +
          "  billion elements on a 64-bit system by setting the enabled attribute of the " +
         "   configuration element to true in the run-time environment." +
"For purposes of enumeration, each item in the dictionary is treated as a KeyValuePair<TKey," +
   " TValue> structure representing a value and its key. The order in which the items are " +
          "  returned is undefined." +
"The foreach statement of the C# language (for each in C++, For Each in Visual Basic) returns" +
   " an object of the type of the elements in the collection. Since the Dictionary<TKey, TValue> " +
           " is a collection of keys and values, the element type is not the type of the key or" +
            "the type of the value. Instead, the element type is a KeyValuePair<TKey, TValue> of " +
           " the key type and the value type.";

            Console.Write("\n");
            Console.WriteLine("-------MAN PAGES MENU-------");
            Console.WriteLine("1.    Stack Page");
            Console.WriteLine("2.    Queue Page");
            Console.WriteLine("3.    Dictionary Page");
            Console.WriteLine("4.    Return to Bonus Features");
            Console.WriteLine("-------All info can be found on Microsoft's website------");
            Console.Write("Menu Selector: ");

            ErrorHandling check = new ErrorHandling();

            int iManMenu = check.Input("Menu Selector: ", 4);

            switch (iManMenu)
            {
                case 1:
                    Console.WriteLine(stackMan);
                    break;
                case 2:
                    Console.WriteLine(queueMan);
                    break;
                case 3:
                    Console.WriteLine(dictionaryMan);
                    break;
                case 4:
                    break;
            }

            Console.WriteLine("\n\n");
        }
    }
}
