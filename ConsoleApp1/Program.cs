namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q02
            //Console.WriteLine("Enter the size :");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Enter the Elements : ");
            //List<int> list = new List<int>();
            //for (int i = 0; i < N; i++)
            //{
            //    list.Add(int.Parse(Console.ReadLine()));
            //}

            //List<int> reversedList = new List<int>(list);
            //reversedList.Reverse();

            //if (list.SequenceEqual(reversedList))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion        }

            #region Q03
            //static void Reverse(Queue<int> queue)
            //{
            //Stack<int> stack = new Stack<int>();

            //foreach (int num in queue)
            //{
            //stack.Push(num);
            //}

            //queue.Clear();
            //foreach (int num in stack)
            //{
            //queue.Enqueue(num);
            //}
            //}





            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Reverse(queue);

            //foreach (int num in queue)
            //{

            //Console.Write(num );
            //}


            #endregion

            #region Q05
            //static int[] remove(int[] array)
            //{
            //int[] result = new int[array.Length];
            //int index = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //bool exists = false;

            //for (int j = 0; j < index; j++)
            //{
            //if (array[i] == result[j])
            //{
            //exists = true;
            //}


            //}
            //}




            //return result;
            //}




            //int[] arr = { 1, 2, 2, 3, 4, 4,4 };


            //Console.WriteLine("Array without duplicates:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //Console.Write(arr[i] );
            //}

            //int removearr =(int) remove(arr);


            #endregion

            #region Q06

            //static void RemoveOddNumbers(List<int> nums)
            //{
            //for (int i = nums.Count - 1; i >= 0; i--)
            //{
            //if (nums[i] % 2 != 0) 
            //{
            //nums.RemoveAt  (i); 
            //}
            //}
            //}








            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //RemoveOddNumbers(numbers);

            //Console.WriteLine("After remove :");
            //foreach (int number in numbers)
            //{
            //Console.Write(number);
            //} 
            #endregion

            #region Q07
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);           
            //queue.Enqueue("Apple");    
            //queue.Enqueue(5.28);       

            //Console.WriteLine("Result :");
            //foreach (var result in queue)
            //{
            //Console.WriteLine(result);
            //} 
            #endregion


        }
    }
}
