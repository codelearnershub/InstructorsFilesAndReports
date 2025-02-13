// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//What is Generic List<T> Collection in C#?
//The Generic List<T> in C# is a Collection Class that belongs to System.Collections.Generic namespace. This Generic List<T> Collection Class represents a strongly typed list of objects which can be accessed by using the integer index which is starting from 0. It also provides lots of methods that can be used for searching, sorting, and manipulating the list of items

//For example, Adding Elements using Add Method of the List Class. As you can see in the below code while creating the Generic List collection instance, we are specifying the type parameter as a string and this allows the collection to store elements of string type only. In this case, the element will be added at the end of the collection.

//List<T> variableName = new List<T>();

List<string> countries = new List<string>();

countries.Add("India");
countries.Add("Srilanka");
countries.Add("Nigeria");

// using object initializer

List<string> names = new List<string>
{
    "Ade",
    "Chuckwu",
    "Danjuma"
};

/*Console.WriteLine(countries[0]);
Console.WriteLine(countries[1]);
Console.WriteLine(countries[2]);*/

//using foreach loop
/*foreach (string country in countries)
{
    Console.WriteLine(country);
}*/

//using for loop
/*for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}*/

/*List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);*/

/*List<int> numbers = new List<int> 
{ 
    1,
    2,
    3,
    4,
    5
};*/

List<int> numbers = new List<int> {1,2,3,4,5 };

/*Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);*/

/*
foreach (int number in numbers)
{
    Console.WriteLine(number);
}*/

/*for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}*/

//Creating Another Generic List Collection of String Type
/*string[] nations = { "Colombia", "Mexico", "Algeria" };

List<string> newCountries = new List<string>(nations);*/

List<string> newCountries = new List<string>();

//Adding Elements using Add Method
newCountries.Add("JAPAN");
newCountries.Add("UK");

//Adding the newCountries collection into countries collection using AddRange Method
countries.AddRange(newCountries);

Console.WriteLine($"the total number of countries is now {countries.Count}");

foreach(string country in countries)
{
    Console.WriteLine(country);
}

//Insert(int index, T item): This method is used to insert an element into the Generic List at the specified index. Here, the parameter index specifies the zero-based index at which an item should be inserted and the parameter item specifies the object to insert. The value can be null for reference types. If the index is less than 0 or the index is greater than Generic List Count, then it will throw ArgumentOutOfRangeException.

//InsertRange(int index, IEnumerable<T> collection): This method is used to insert the elements of a collection into the Generic List at the specified index. Here, the parameter index specifies the zero-based index at which an item should be inserted. The parameter collection specifies the collection whose elements should be inserted into the Generic List. The collection itself cannot be null, but it can contain elements that are null if type T is a reference type. If the collection is null, then it will throw ArgumentNullException. If the index is less than 0 or the index is greater than Generic List Count, then it will throw ArgumentOutOfRangeEx

//inserting single element
/*List<string> states = new List<string> { "Lagos", "Abuja", "Port-Harcourt" };
Console.WriteLine($" The initial count is {states.Count}");

states.Insert(0, "Ogun");

Console.WriteLine($"The current count is {states.Count}");

for(int i = 0; i < states.Count; i++)
{
    Console.WriteLine(states[i]);
}

//Adding multiple states
List<string> newstates = new List<string> { "Abia", "Bauchi", "Calabar" };

states.InsertRange(0, newstates);

Console.WriteLine($"After adding range of states, The current count is {states.Count}");

foreach(string state in states)
{
    Console.WriteLine(state);
}*/

// How to Check the Availability of an Element in a List Collection in C#?
//If you want to check whether an element exists or not in the Generic List Collection, then you need to use the following Contains method of the Generic List Collection Class in C#.

//Contains(T item): The Contains(T item) method of the Generic List Collection Class is used to check if the given item is present in the List or not. The parameter item specifies the object to locate in the Generic List. The value can be null for reference types. It returns true if the item is found in the Generic List; otherwise, false.

/*List<int> nums = new List<int>();

nums.Add(1);
nums.Add(2);    
nums.Add(3);
nums.Add(4);
nums.Add(5);

bool result = nums.Contains(1);
Console.WriteLine(result);

bool result1 = nums.Contains(6);
Console.WriteLine(result1);

bool result2 = nums.Contains(87);

if (result2 == true)
{
    nums.Remove(5);
    Console.WriteLine("The element has been removed successfully");
}
else
{
    Console.WriteLine("The element does not exist in the collection");
}*/


// using RemoveAt
List<int> values = new List<int> { 2, 4, 5, 2, 6, 7, 2, 9, 0 };
values.RemoveAt(0); // specify the index of the element to be removed

//Using RemoveAll

//Remove all element 2

values.RemoveAll(x => x == 2);

for (int i = 0; i < values.Count; i++)
{
    if (values[i] == 2)
    {
        values.Remove(values[i]);
    }
}

foreach (int i in values)
{
    Console.WriteLine(i);
}
values.Clear(); // Removes everthing int the collection

//Summary of Generic List<T> Collection Class in C#:
//The List<T> collection is different from the arrays. The List can be resized dynamically but arrays cannot resize dynamically.

//The Generic List<T> Collection Class in C# can accept null values for reference types and it also accepts duplicate values.

//When the element’s Count becomes equal to the Capacity of the list collection, then the capacity of the List increased automatically by reallocating the internal array. The existing elements will be copied to the new array before the addition of the new element.

//The Generic List class is the generic equivalent of the Non-Generic ArrayList class.

//The Generic List<T> class implements the IList<T> generic interface.

//We can use both equality and ordering comparer with the generic List class.

//The List<T> class elements are not sorted by default and elements are accessed by a zero-based index.

//For very large List<T> objects, you can increase the maximum capacity to 2 billion elements on a 64-bit system by setting the enabled attribute of the configuration element to true in the run-time environment.


