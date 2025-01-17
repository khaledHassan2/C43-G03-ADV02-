using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static int sum(ArrayList ar)
        {
            int Sum = 0;
            if (ar is not null)
            {
                for (int i = 0; i < ar.Count; i++)
                {
                    Sum += (int?)ar[i] ?? 0;
                }
                return Sum;
            }
            return 0;
        }
        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }
                return Sum;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            #region non genaric collection [array list]
            //ArrayList array = new ArrayList();
            //Console.WriteLine($"count = {array.Count}  / capacity: {array.Capacity}");

            //array.Add( 1 );
            //array.Add( 2 );
            //array.AddRange( new object[] { 3,4 } );
            //Console.WriteLine("after add elements");
            //Console.WriteLine($"count = {array.Count}  / capacity: {array.Capacity}");

            //array.Add( 5 );
            //Console.WriteLine("after add element 5");
            //Console.WriteLine($"count = {array.Count}  / capacity: {array.Capacity}");

            //array.TrimToSize();
            //Console.WriteLine("after triming");
            //Console.WriteLine($"count = {array.Count}  / capacity: {array.Capacity}");



            #endregion

            #region genaric collection [Arraylist]
            //ArrayList array2 = new ArrayList(5) { 1,2,3,4,5};
            //Console.WriteLine($"count = {array2.Count}  / capacity: {array2.Capacity}");

            //array2.Add(6);
            //Console.WriteLine("after add 6");
            //Console.WriteLine($"count = {array2.Count}  / capacity: {array2.Capacity}");

            //ArrayList array3 = new ArrayList();
            //array3.Add(1);
            //array3.Add(2);
            //array3.Add(3);
            //array3.Add("hamada");
            ////compiler cannot inforce number 6
            //int re=sum(array3);
            //Console.WriteLine($" result{re}");
            #endregion

            #region genaric collection [list]
            //List<int> array3 = new List<int>();

            //array3.Add(1);
            //array3.Add(2);
            //array3.Add(3);
            //array3.AddRange(new int[] {4,5 });
            //array3.TrimExcess();
            //     // array3.Add("ay7aga"); error
            //Console.WriteLine($"count = {array3.Count}  / capacity: {array3.Capacity}");

            ////compiler cannot inforce number 6
            //int re =SumList(array3);
            //Console.WriteLine($" result: {re}");
            #endregion
        }
    }
}
