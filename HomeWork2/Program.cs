/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.5*/

 



double ImputInt (){
    Console.WriteLine("Введите число");
    bool isNum = double.TryParse (Console.ReadLine(),out double num);
    if (isNum){
        return num;
    }
    else {
        Console.WriteLine ("Вы ввели некорректное значение");
        return  -1;
    }
}

double ax = ImputInt ();
double ay = ImputInt ();
double az = ImputInt ();
double bx = ImputInt ();
double by = ImputInt ();
double bz = ImputInt ();


double DistanceTwoPointsInThreeDSpace (double ax,double bx,double ay,double by,double az,double bz){
double ab = Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az));
return ab;
}
double result = DistanceTwoPointsInThreeDSpace (ax,bx,ay,by,az,bz);
Console.WriteLine(result);