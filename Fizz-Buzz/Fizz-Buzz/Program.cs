using System;



public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
         
        for(int i = 0; i< numbers.Length; i++)
        {
            Console.WriteLine((numbers[i] % 3 == 0 && numbers[i] % 4 == 0 && numbers[i] % 5 == 0 && numbers[i] % 7 == 0) ? "good-boy-muzz-guzz" :
                (numbers[i] % 3 == 0 && numbers[i] % 4 != 0 && numbers[i] % 5 == 0 && numbers[i] % 7 == 0) ? "good-boy-guzz" :
                (numbers[i] % 3 == 0 && numbers[i] % 4 == 0 && numbers[i] % 5 == 0 && numbers[i] % 7 != 0) ? "good-boy-muzz" :
                (numbers[i] % 3 == 0 && numbers[i] % 5 == 0) ? "good-boy" :
                (numbers[i] % 4 == 0 && numbers[i] % 7 == 0) ? "muzz-guzz" :
                (numbers[i] % 3 == 0 && numbers[i] % 4 == 0) ? "fizz-muzz" :
                numbers[i] % 3 == 0 ? "dog":
                numbers[i] % 4 == 0 ? "muzz":
                numbers[i] % 5 == 0 ? "cat":
                numbers[i] % 7 == 0 ? "guzz":
                numbers[i].ToString()) ; 
            /*Это условие которое написано в краткой форме где проверям каждого числа, в случае если 
             не равны остаткии с нулем они будут значить что они не делятся без остатка поэтому мы в самом конце 
            будем выводить только значение индекса этого массива*/
        }
    }
}