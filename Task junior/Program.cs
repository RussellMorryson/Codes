Console.WriteLine("Программа для подсчета результатов торговли!");

/*Условия в задаче:
1 <= a <= 30
0 <= b <= a   */


/* Необходимо написать программу подсчитывающую наибольшее 
количество возможных исходов, при которых никто из 
покупателей не уйдет без воды, и все получат сдачу*//

//a, b, b, b, a - 2500


int a = 500; //3
int b = 1000; //2
int box = 0;

int [] array = {a, b, b, b, b};
int len = array.Length;
int index = 0;
while (index<len){
    if (array[index] > 500) {
        if (box < 0){
            Console.WriteLine("Error!");
            //break;
        }
        else if (box >= 500) {
            box = box + array[index] - 500;
        }
    }  
    else {
        box += array[index];
    }
    Console.WriteLine(box);
    index++;
}



