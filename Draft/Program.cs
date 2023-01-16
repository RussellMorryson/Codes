
/*Дополнительно:
1 <= a <= 30
0 <= b <= a   */
/*int a = 500;
int b = 1000;
//int j = new Random().Next(0, 30);
string [] tab = new string [5];

int i = 0;
while (i < 10) {
    tab[i] = new Random().Next(a, b);
    Console.WriteLine(tab[i]);
    i++;    
}
*/

int How_numbers_A = 3;
int How_numbers_B = 2;




char[] array = new char[5];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++) {
    array[i] = Convert.ToChar(rnd.Next('a', 'b' + 1));
    Console.Write("{0} ", array[i]);
}
//b a a b b
int index_A = 0;
int index_B = 0;
char char_A = 'a';



for (int j = 0; j < array.Length; j++){
    if (array[j] == char_A){
        index_A ++; 
    }
    else {
        index_B ++; 
    }    
}

if (index_A > How_numbers_A) {

    Console.WriteLine("Error a > 3");
}




//Console.ReadKey(true);






