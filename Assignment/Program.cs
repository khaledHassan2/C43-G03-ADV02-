namespace Assignment
{
    internal class Program
    {
        #region AD02 method
        //public static int sum(ArrayList ar)
        //{
        //    int Sum = 0;
        //    if (ar is not null)
        //    {
        //        for (int i = 0; i < ar.Count; i++)
        //        {
        //            Sum += (int?)ar[i] ?? 0;
        //        }
        //        return Sum;
        //    }
        //    return 0;
        //}
        //public static int SumList(List<int> list)
        //{
        //    int Sum = 0;
        //    if (list is not null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            Sum += list[i];
        //        }
        //        return Sum;
        //    }
        //    return 0;
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Q01)Try Every Point Covered in the Lecture.
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

            #region List Method
            //List<int> list = new List<int>() { 1,2,3,4,5};
            //list.Insert(0, 2);
            ////list.InsertRange(1   int[] {1,2,3,5});
            #endregion

            #endregion

            #region Q02)Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
            //Book MyBook = new Book("957-55", "C#", new string[] {"khaled","mostsfa","rana"},new DateTime(2000,10,03),55.99m);

            //Console.WriteLine("Book Details");
            //Console.WriteLine("Title" + BookFunctions.GetTitle(MyBook));
            //Console.WriteLine("Authors" + BookFunctions.GetAuthors(MyBook));
            //Console.WriteLine("Price" + BookFunctions.GetPrice(MyBook));
            #endregion




        }
    }
}
