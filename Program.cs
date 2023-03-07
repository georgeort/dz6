// 1

void task1(int count){
    int counter = 0;
    int [] masive = new int [count];
    for (int i = 0; i <count; i++){
        Console.Write("Введите число ");
        masive[i] = Convert.ToInt32(Console.ReadLine());
        if (masive[i]>0) counter++;
    }
    Console.WriteLine($"{counter}");
}
task1(3);

//2
void task2(){
    Console.Write("Введите число b1 ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число k1 ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число b2 ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число k2 ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"({(b2-b1)/(k1-k2)}, {(b1*k2 - b2*k1)/(k2 - k1)})");
}
task2();

//3
void task3(){
    Console.Write("Введите число ");
    int user = Convert.ToInt32(Console.ReadLine());
    string output="";
    while(user>0){
        if(user%2==0){
            user/=2;
            output+="0";
        }else{
            user--;
            user/=2;
            output+="1";
        }
    }
    output.Reverse();
    Console.WriteLine($"{output}");
}
task3();