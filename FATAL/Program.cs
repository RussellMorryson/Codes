int a = 500; //3
int b = 1000; //2
int box = 0;

// Создание массива из случайного набора a и b
char[] array = new char[5]; // объем массива 5 элементов
Random rnd = new Random(); // определяется переменная rnd, как функция вызова рандома
for (int i = 0; i < array.Length; i++) {
    array[i] = Convert.ToChar(rnd.Next('a', 'b' + 1)); // В формировании массива будут только символы a и b
    Console.Write("{0} ", array[i]);
}
// Создание массива со значениями a = 500 и b = 1000
int [] IntArray = new int [5]; // объем массива 5 элементов
for (int e = 0; e < IntArray.Length; e++) { // присвоение значений по порядку
    if (array[e] == 'a') {
        IntArray[e] = 500;
    }
    else {
        IntArray[e] = 1000;
    }
}

// Торговля через кассу
// Если в кассе недостаточно сдачи, то покупатель уходит ни с чем, но
// не учитывается номинал купюр
int len = IntArray.Length;
int index = 0;
while (index<len){
    if (IntArray[index] > 500) {
        if (box < 0){
            Console.WriteLine("Error!");
        }
        else if (box >= 500) {
            box = box + IntArray[index] - 500;
        }
    }  
    else {
        box += IntArray[index];
    }
    Console.WriteLine(box);
    index++;
}