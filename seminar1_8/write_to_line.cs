// See https://aka.ms/new-console-template for more information

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (-1 <= num &&  num <= 1){
    Console.WriteLine("output nothing");
}
else if (num < -1){
    for(int i = 1; i >= num; i--){
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
    }   
}
else if (num > 1){
    for(int i = 1; i <= num; i++){
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
    }   
}